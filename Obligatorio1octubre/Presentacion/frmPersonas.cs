using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Obligatorio1octubre.Presentacion
{
    public partial class frmPersonas : Form
    {
        public frmPersonas()
        {
            InitializeComponent();
        }
        private bool faltanDatos()
        {
            if (this.txtId.Text == "" || this.txtNombre.Text == "" || this.txtApellido.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool FechasCorrectas()
        {
            if (this.txtNacinalidad.Text == "" )
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        private void limpiar()
        {
            this.txtId.Clear();
            this.txtNombre.Clear();
            this.txtApellido.Clear();
            this.txtFallecido.Clear();
            this.dteFechaDeNac.ResetText();
            this.txtNacinalidad.Clear();
            this.lblMensajes.Text = "";
            this.txtId.Focus();

        }


        private void listar()
        {
            Dominio.Municipalidad unaMunicipalidad = new Dominio.Municipalidad();
            this.lstAutor.DataSource = null;
            this.lstAutor.DataSource = unaMunicipalidad.ListaAutores();
            this.lstAutor.SelectedIndex = -1;
            this.lstLectores.DataSource = null;
            this.lstLectores.DataSource = unaMunicipalidad.ListaLectores();
            this.lstLectores.SelectedIndex = -1;

        }
        private void CargarAutor(short pId)
        {
            Dominio.Municipalidad unaMunicipalidad = new Dominio.Municipalidad();
            Dominio.Autor unAutor = unaMunicipalidad.BuscarAutor(pId);

            this.txtId.Text = Convert.ToString(unAutor.Id);
            this.txtNombre.Text = unAutor.Nombre;
            this.txtApellido.Text = unAutor.Apellido;
            this.dteFechaDeNac.Value = unAutor.FechaDeN;
            this.txtFallecido.Text = unAutor.FechaDeF;
            this.txtNacinalidad.Text = unAutor.Nacionalidad;
            if (unAutor.FechaDeF == "No ha fallecido")
            {
                cbxFallecido.Checked = false;
            }
            else
            {
                cbxFallecido.Checked = true;
            }

        }
        private void CargarLectores(short pId)
        {
            Dominio.Municipalidad unaMunicipalidad = new Dominio.Municipalidad();
            Dominio.Lector unLector = unaMunicipalidad.BuscarLector(pId);
            this.txtId.Text = Convert.ToString(unLector.Id);
            this.txtNombre.Text = unLector.Nombre;
            this.txtApellido.Text = unLector.Apellido;
        }

        private void lstAutor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Dominio.Municipalidad unaMunicipalidad = new Dominio.Municipalidad();


            if (!this.faltanDatos())
            {
                short id = short.Parse(this.txtId.Text);
                string nombre = this.txtNombre.Text;
                string apellido = this.txtApellido.Text;
                

                
                if (this.rbdAutor.Checked)
                {
                    DateTime FechaDeNac = this.dteFechaDeNac.Value;
                    string nacionalidad = this.txtNacinalidad.Text;
                    string FechaDeFall = this.txtFallecido.Text;
                    if (this.cbxFallecido.Checked)
                    {
                        if (!this.FechasCorrectas())
                        {
                            Dominio.Autor unAutor = new Dominio.Autor(id, nombre, apellido, nacionalidad, FechaDeNac, FechaDeFall);

                            if (unaMunicipalidad.AltaAutor(unAutor))
                            {
                                this.limpiar();
                                this.listar();
                                this.lblMensajes.Text = "Autor ingresado con exito";
                            }
                            else
                            {

                                this.lblMensajes.Text = "Autor ya existe";
                            }
                        }
                        else
                            this.lblMensajes.Text = "Faltan datos o las fechas estan incorrectas";
                    }
                    else
                    {

                        if (!this.FechasCorrectas())
                        {
                            string FechadeFall = "No ha fallecido";
                            Dominio.Autor unAutor = new Dominio.Autor(id, nombre, apellido, nacionalidad, FechaDeNac, FechadeFall);

                            if (unaMunicipalidad.AltaAutor(unAutor))
                            {
                                this.limpiar();
                                this.listar();
                                this.lblMensajes.Text = "Autor ingresado con exito";
                            }
                            else
                            {

                                this.lblMensajes.Text = "Autor ya existe";
                            }
                        }
                        else
                            this.lblMensajes.Text = "Faltan datos o las fechas estan incorrectas";

                    }
                }
                else if(this.rbdLectores.Checked)
                {
                    {
                        Dominio.Lector unLector = new Dominio.Lector(id, nombre, apellido);
                        if (unaMunicipalidad.AltaLector(unLector))
                        {
                            this.limpiar();
                            this.listar();
                            this.lblMensajes.Text = "Lector ingresado con exito";

                        }
                        else
                        {
                            this.lblMensajes.Text = "Lector ya existe";
                        }

                    }
                }
            }
        
            else
            {
                this.lblMensajes.Text = "Faltan datos";
            }

          
        }
    
    

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Dominio.Municipalidad unaMunicipalidad = new Dominio.Municipalidad();
            if (!this.faltanDatos())
            {
                short id = short.Parse(this.txtId.Text);
                if (this.rbdAutor.Checked)
                {
                    if (unaMunicipalidad.BajaAutor(id))
                    {
                        this.limpiar();
                        this.listar();
                        this.lblMensajes.Text = "Autor eliminado con exito";
                    }
                    else
                    {
                        this.limpiar();
                        this.lblMensajes.Text = "No se elimino, no se encontro";
                    }
                }
                else if(this.rbdLectores.Checked)
                {
                    if(unaMunicipalidad.BajaLector(id))
                    {
                        this.limpiar();
                        this.listar();
                        this.lblMensajes.Text = "Lector eliminado con exito";

                    }
                    else
                    {
                        this.limpiar();
                        this.lblMensajes.Text = "No se elimino, no se encontro";
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Dominio.Municipalidad unaMunicipalidad = new Dominio.Municipalidad();
            if (!this.faltanDatos())
            {
                short id = Convert.ToInt16(this.txtId.Text);
                string nombre = this.txtNombre.Text;
                string apellido = this.txtApellido.Text;
                if (this.rbdAutor.Checked)
                {
                    if (this.cbxFallecido.Checked)
                    {
                        if (!this.FechasCorrectas())
                        {
                            DateTime FechaDeNac = this.dteFechaDeNac.Value;
                            string FechaDeFall = this.txtFallecido.Text;
                            string nacionalidad = this.txtNacinalidad.Text;
                            if (rbdAutor.Checked)
                            {
                                if (unaMunicipalidad.ModificarAutor(id, nombre, apellido, nacionalidad, FechaDeNac, FechaDeFall))
                                {
                                    this.limpiar();
                                    this.listar();
                                    this.lblMensajes.Text = "Autor modificado modificado";

                                }
                                else
                                {
                                    this.limpiar();
                                    this.lblMensajes.Text = "No se pudo modificar el autor";
                                }
                            }
                        }
                    }
                    else
                    {
                        if (!this.FechasCorrectas())
                        {
                            DateTime FechaDeNac = this.dteFechaDeNac.Value;
                            string FechaDeFall = "No ha fallecido";
                            string nacionalidad = this.txtNacinalidad.Text;
                            if (rbdAutor.Checked)
                            {
                                if (unaMunicipalidad.ModificarAutor(id, nombre, apellido, nacionalidad, FechaDeNac, FechaDeFall))
                                {
                                    this.limpiar();
                                    this.listar();
                                    this.lblMensajes.Text = "Autor modificado modificado";

                                }
                                else
                                {
                                    this.limpiar();
                                    this.lblMensajes.Text = "No se pudo modificar el autor";
                                }
                            }
                        }
                    }

                }
                else if (rbdLectores.Checked)
                {
                    if (unaMunicipalidad.ModificarLector(id, nombre, apellido))
                    {
                        this.limpiar();
                        this.listar();
                        this.lblMensajes.Text = "Lector Modificado";
                    }
                    else
                    {
                        this.limpiar();
                        this.lblMensajes.Text = "No se pudo modificar el lector";

                    }
                }
              
                
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void frmAutor_Load(object sender, EventArgs e)
        {
            this.listar();
        }

        private void rdbAutor_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rbdAutor.Checked)
            {
                this.gbpAutor.Visible = true;

            }
            else
            {
                this.gbpAutor.Visible = false;
            }
        }

        private void rbdLectores_CheckedChanged(object sender, EventArgs e)
        {

        }

     
       
        private void lstLectores_Click(object sender, EventArgs e)
        {
            rbdLectores.Checked = true;
            byte numero = Convert.ToByte(this.lstLectores.SelectedIndex);
            string linea = this.lstLectores.SelectedItem.ToString();
            string[] partes = linea.Split(' ');
            short id = short.Parse(partes[0]);
            this.CargarLectores(id);
        }

        private void cbxFallecido_CheckedChanged(object sender, EventArgs e)
        {
            if(this.cbxFallecido.Checked == true)
            {
                this.txtFallecido.Enabled = true;
            }
            else
            {
                this.txtFallecido.Enabled = false;
            }
        }

        private void lstAutor_Click_1(object sender, EventArgs e)
        {
            rbdAutor.Checked = true;
            byte numero = Convert.ToByte(this.lstAutor.SelectedIndex);
            string linea = this.lstAutor.SelectedItem.ToString();
            string[] partes = linea.Split(' ');
            short id = short.Parse(partes[0]);
            this.CargarAutor(id);
        }

        private void lstLectores_Click_1(object sender, EventArgs e)
        {
            rbdLectores.Checked = true;
            byte numero = Convert.ToByte(this.lstLectores.SelectedIndex);
            string linea = this.lstLectores.SelectedItem.ToString();
            string[] partes = linea.Split(' ');
            short id = short.Parse(partes[0]);
            this.CargarLectores(id);
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            this.listar();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "0123456789.-" + (char)8 + (char)127;
            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ " + (char)8 + (char)127;
            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ " + (char)8 + (char)127;
            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNacinalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ " + (char)8 + (char)127;
            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFallecido_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "0123456789.-" + (char)8 + (char)127;
            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
