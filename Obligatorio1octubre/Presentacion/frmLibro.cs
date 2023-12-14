using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Obligatorio1octubre.Presentacion
{
    public partial class frmLibro : Form
    {
        public frmLibro()
        {
            InitializeComponent();
        }
        #region Lista
       


        private void ListarAutores()
        {
            Dominio.Municipalidad unaMunicipalidad = new Dominio.Municipalidad();
            this.cbAutor.DataSource = null;
            this.cbAutor.DataSource = unaMunicipalidad.ListaAutores(); 
        }
        private void ListarXOrden()
        {
            Dominio.Municipalidad unaMunicipalidad = new Dominio.Municipalidad();
            this.lstLibros.DataSource = null;
            this.lstLibros.DataSource = unaMunicipalidad.ListaLibros();
            this.lstLibros.SelectedIndex = -1;
            ordenABC = false;
        }
        private void ListarXABC()
        {
            Dominio.Municipalidad unaMunicipalidad = new Dominio.Municipalidad();
            this.lstLibros.DataSource = null;
            this.lstLibros.DataSource = unaMunicipalidad.ListaOrdenadaLibro();
            this.lstLibros.SelectedIndex = -1;
            ordenABC = true;
        }

        bool ordenABC = false;
        private void Listar()
        {
            if(ordenABC)
            {
                ListarXABC();
            }
            else
            {
                ListarXOrden();
            }
        }
        #endregion
        #region Botones
        private void btnAltaLibro_Click(object sender, EventArgs e)
        {
           
            Dominio.Municipalidad unaMunicipalidad= new Dominio.Municipalidad();
            if (!faltanDatos())
            {
                short id = short.Parse(this.txtId.Text);
                string titulo = this.txtTitulo.Text;
                string genero = this.txtGenero.Text;
                DateTime año = this.dtpAño.Value;
                Dominio.Autor autor = this.AutorSelec();
               
                double precio = short.Parse(this.txtPrecio.Text);
                string comentario = this.txtComentario.Text;

                Dominio.Libro unLibro = new Dominio.Libro(id, titulo, genero, año, autor, precio, comentario);
                if (unaMunicipalidad.AltaLibro(unLibro))
                {
                    this.Limpiar();
                    this.lblMensaje.Text = "Libro ingresado con exito";
                    this.Listar();
                }
                else
                {
                    this.txtId.Clear();
                    this.txtId.Focus();
                    this.lblMensaje.Text = "Ya existe un libro con ese ID";
                }
            }
            else
            {
                this.lblMensaje.Text = "Ingrese todos los datos";
            }
        }

        private Dominio.Autor AutorSelec()
        {
            if (this.cbAutor.ValueMember != null)
            {
                Dominio.Municipalidad unaMunicipalidad = new Dominio.Municipalidad();

                string CliSt = this.cbAutor.SelectedItem.ToString();
                string[] CliArr = CliSt.Split(' ');
                short AutorId = short.Parse(CliArr[0]);
                Dominio.Autor vec = unaMunicipalidad.BuscarAutor(AutorId);
                if (vec != null)
                {
                    return vec;

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
        #endregion
        #region Auxiliares
        private Boolean faltanDatos()
        {
            if (this.txtId.Text == "" || this.txtTitulo.Text == "" || this.txtGenero.Text == "" || this.dtpAño.Text == "" || this.cbAutor.Text == "" || this.txtPrecio.Text == "" || this.txtComentario.Text == "")
            {
                return true;
            }
            return false;
        }

        private void Limpiar()
        {
            this.txtId.Clear();
            this.txtTitulo.Clear();
            this.txtGenero.Clear();
            this.dtpAño.ResetText();
            this.cbAutor.ResetText();
            this.txtPrecio.Clear();
            this.txtComentario.Clear();
            this.txtId.Focus();
        }

        private void CargarLibro(short pId)
        {
            Dominio.Municipalidad unaMunicipalidad = new Dominio.Municipalidad();
            Dominio.Libro unLibro = unaMunicipalidad.BuscarLibro(pId);

            this.txtId.Text = Convert.ToString(unLibro.Id);
            this.txtTitulo.Text = unLibro.Titulo;
            this.txtGenero.Text = unLibro.Genero;
            this.dtpAño.Value = unLibro.Ano;
            this.cbAutor.Text = unLibro.Autor.ToString();
            this.txtPrecio.Text = unLibro.Precio.ToString();
            this.txtComentario.Text = unLibro.Comentario;

        }
        #endregion

      

        private void frmLibro_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.ListarAutores();
        }

        private void btnBajaLibro_Click(object sender, EventArgs e)
        {
            Dominio.Municipalidad unaMunicipalidad = new Dominio.Municipalidad();
            short id = short.Parse(this.txtId.Text);
            if (unaMunicipalidad.BajaLibro(id))
            { 
                Limpiar();
                Listar();
                this.lblMensaje.Text = "El libro ha sido dado de baja con exito!";
            }
            else
            {
                this.lblMensaje.Text = "No hay libros con ese Id!";
            }
        }
        
        private void lstLibros_Click(object sender, EventArgs e)
        {
            string linea = this.lstLibros.SelectedItem.ToString();
            string[] partes = linea.Split(' ');
            short id = short.Parse(partes[0]);
            this.CargarLibro(id);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!faltanDatos())
            {
                Dominio.Municipalidad unaMunicipalidad = new Dominio.Municipalidad();
                short id = short.Parse(this.txtId.Text);
               
                string Titulo = this.txtTitulo.Text;
                string Genero = this.txtGenero.Text;
                DateTime Ano = this.dtpAño.Value;
                Dominio.Autor unAutor = this.AutorSelec(); 
                double precio = short.Parse(this.txtPrecio.Text);
                string Comentario = this.txtComentario.Text;
                if (unaMunicipalidad.ModificarLibro(id, Titulo, Genero, Ano, unAutor, precio, Comentario))
                 {
                    Limpiar();
                    Listar();
                    this.lblMensaje.Text = "El libro ha sido dado modificado con exito!";
                }
                else
                {
                    this.lblMensaje.Text = "error";
                }
            }
            else
            {
                this.lblMensaje.Text = "Faltan datos!";
            }
        }

        private void rbdOrden_CheckedChanged(object sender, EventArgs e)
        {
            this.ListarXOrden();
        }

        private void rbdTitulo_CheckedChanged(object sender, EventArgs e)
        {
            this.ListarXABC();
        }

      

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            this.ListarAutores();
            this.Listar();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            this.ListarAutores();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "0123456789" + (char)8 + (char)127;
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

        private void txtGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ " + (char)8 + (char)127;
            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "" ;
            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "0123456789.-" + (char)8 + (char)127;
            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtComentario_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ " + (char)8 + (char)127;
            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
