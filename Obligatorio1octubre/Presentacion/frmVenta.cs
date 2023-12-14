using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Obligatorio1octubre.Presentacion
{
    public partial class frmVenta : Form
    {
        public frmVenta()
        {
            InitializeComponent();
        }
        #region AUXILIARES
        private bool faltanDatos()
        {
            if (this.txtId.Text == "" || this.txtLibro.Text == "" || this.dtpFechaVe.Text == "" || this.cbxLector.Text == "" || this.txtAutor.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void CargarVenta(short pId)
        {
            Dominio.Municipalidad unaMunicipalidad = new Dominio.Municipalidad();
            Dominio.Venta unaVenta = unaMunicipalidad.BuscarVenta(pId);

            this.txtId.Text = Convert.ToString(unaVenta.Id);
            this.dtpFechaVe.Value = unaVenta.FechaVen;
            this.txtTitulo.Text = unaVenta.Libro.Titulo;
            this.txtAutor.Text = unaVenta.Autor.ToString();
            this.txtLibro.Text = unaVenta.Libro.ToString();
            this.cbxLector.Text = unaVenta.Lector.ToString();

        }
        private Dominio.Libro LibroSelec()
        {
            if (this.txtLibro.Text != null)
            {
                Dominio.Municipalidad unaMunicipalidad = new Dominio.Municipalidad();
                string libro = this.txtLibro.Text.ToString();
                string[] libroArray = libro.Split(' ');
                short libroId = short.Parse(libroArray[0]);
                Dominio.Libro libroObj = unaMunicipalidad.BuscarLibro(libroId);
                if (libroObj != null)
                {
                    return libroObj;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

     

        private Dominio.Lector LectorSelec()
        {
            if (this.txtLibro.Text != null)
            {
                Dominio.Municipalidad unaMunicipalidad = new Dominio.Municipalidad();
                string lector = this.cbxLector.SelectedItem.ToString();
                string[] lectorArray = lector.Split(' ');
                short lectorId = short.Parse(lectorArray[0]);
                Dominio.Lector lectorObj = unaMunicipalidad.BuscarLector(lectorId);
                if (lectorObj != null)
                {
                    return lectorObj;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        private void Limpiar()
        {
            this.txtId.Clear();
            this.txtTitulo.Clear();
            this.dtpFechaVe.ResetText();
            this.txtAutor.ResetText();
            this.txtLibro.Clear();
            this.cbxLector.ResetText();
            this.txtId.Focus();
        }
        #endregion
        #region LISTAR
        private void listarLibros()
        {
            Dominio.Municipalidad unaMunicipalidad = new Dominio.Municipalidad();
            this.lstLibros.DataSource = null;
            this.lstLibros.DataSource = unaMunicipalidad.ListaLibros();
            this.lstLibros.SelectedIndex = -1;
        }

        private void ListarLectores()
        {
            Dominio.Municipalidad unaMunicipalidad = new Dominio.Municipalidad();
            this.cbxLector.DataSource = null;
            this.cbxLector.DataSource = unaMunicipalidad.ListaLectores();
            this.lstLibros.SelectedIndex = -1;
        }
        private void ListarVentas()
        {
            Dominio.Municipalidad unaMunicipalidad = new Dominio.Municipalidad();
            this.lstVentas.DataSource = null;
            this.lstVentas.DataSource = unaMunicipalidad.ListaVentas();
            this.lstVentas.SelectedIndex = -1;
        }
        #endregion
        private void frmVenta_Load(object sender, EventArgs e)
        {
            listarLibros();
            ListarLectores();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dominio.Municipalidad unaMunicipalidad = new Dominio.Municipalidad();

            if (!this.faltanDatos())
            {
                short id = short.Parse(this.txtId.Text);
                DateTime fechaVenta = this.dtpFechaVe.Value;
                string autorAux = this.txtAutor.Text.ToString();
                string[] autorArray = autorAux.Split(' ');
                short autorId = short.Parse(autorArray[0]);
                Dominio.Autor autor = unaMunicipalidad.BuscarAutor(autorId);
                int cant = autor.LibrosVend;
                Dominio.Libro libro = LibroSelec();
                short Idlibro = libro.Id;
                int VentLib = libro.CantVend;
                Dominio.Lector lector = LectorSelec();
                unaMunicipalidad.IngresoCant(autorId);   
                // cuidado que si sale error cuenta como venta areggglar
                
                unaMunicipalidad.IngresoLibCant(Idlibro, VentLib);
                Dominio.Venta unaVenta = new Dominio.Venta(id, fechaVenta, libro, autor, lector);

                if (unaMunicipalidad.Altavent(unaVenta))
                {
                    this.Limpiar();
                    this.ListarVentas();
                    this.lblMensajes.Text = "Venta realizada con exito";
                }
                else
                {
                    this.lblMensajes.Text = "El Id ya existe";
                }
            }
            else
            {
                this.lblMensajes.Text = "Faltan datos";
            }
        }
    

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            string busqueda = this.txtTitulo.Text.ToUpper();
            Dominio.Municipalidad unaMunicipalidad = new Dominio.Municipalidad();
            List<Dominio.Libro> listaLibrosAux = new List<Dominio.Libro>();

            foreach(Dominio.Libro x in unaMunicipalidad.ListaLibros())
            {
                string aux = x.Titulo.ToUpper();
                if(busqueda.Equals(aux))
                {
                    listaLibrosAux.Add(x);
                }
            }

            this.lstLibros.DataSource = null;
            this.lstLibros.DataSource = listaLibrosAux;
            this.lstLibros.SelectedIndex = -1;
        }

        private void lstLibros_Click(object sender, EventArgs e)
        {
            Dominio.Municipalidad unaMunicipalidad = new Dominio.Municipalidad();

            //Busca al autor y lo pone en el txtAutor
            string linea = this.lstLibros.SelectedItem.ToString();
            string[] partes = linea.Split(' ');
            short id = short.Parse(partes[0]);
            Dominio.Libro libroSelected = unaMunicipalidad.BuscarLibro(id);

            this.txtAutor.Text = libroSelected.Autor.ToString();

            //Pone el titulo del libro en el txt
            this.txtTitulo.Text = libroSelected.Titulo;
            //Lo pongo en el txtLibro para tomar el dato y guardarlo en la venta
            this.txtLibro.Text = libroSelected.ToString();
           
        }

   

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Dominio.Municipalidad unaMunicipalidad = new Dominio.Municipalidad();
            short id = short.Parse(this.txtId.Text);
            string autorAux = this.txtAutor.Text.ToString();
            string[] autorArray = autorAux.Split(' ');
            short autorId = short.Parse(autorArray[0]);
            Dominio.Autor autor = unaMunicipalidad.BuscarAutor(autorId);
            int cant = autor.LibrosVend;
            Dominio.Libro libro = LibroSelec();
            short Idlibro = libro.Id;
            int VentLib = libro.CantVend;

            unaMunicipalidad.IngresoCunt(autorId, cant);

            unaMunicipalidad.IngresoLibCunt(Idlibro, VentLib);
            if (unaMunicipalidad.Bajavent(id))
            {
                Limpiar();
                ListarVentas();
                this.lblMensajes.Text = "El libro ha sido dado de baja con exito!";
            }
            else
            {
                this.lblMensajes.Text = "No hay libros con ese Id!";
            }
        }

        private void lstVentas_Click(object sender, EventArgs e)
        {
            byte numero = Convert.ToByte(this.lstVentas.SelectedIndex);
            string linea = this.lstVentas.SelectedItem.ToString();
            string[] partes = linea.Split(' ');
            short id = short.Parse(partes[0]);
            this.CargarVenta(id);
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            this.listarLibros();
            this.ListarLectores();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "0123456789.-" + (char)8 + (char)127;
            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ " + (char)8 + (char)127;
            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbxLector_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "";
            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
