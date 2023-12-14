using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Obligatorio1octubre.Presentacion
{
    public partial class frmEstadisticas : Form
    {
        public frmEstadisticas()
        {
            InitializeComponent();
        }

        private void frmEstadisticas_Load(object sender, EventArgs e)
        {
           

        }
     private void Limpiar()
        {
            this.lblConsulta1.Text = "";
        }

        private void btnConsulta1_Click(object sender, EventArgs e)
        {
            Dominio.Municipalidad municipalidad = new Dominio.Municipalidad();
            if (municipalidad.Recuadacion() != 0)
            {
                this.Limpiar();
                this.lblConsulta1.Text = "La recaudacion total fue: " +  Convert.ToString(municipalidad.Recuadacion());
              
            }
        }

        private void btnConsulta2_Click(object sender, EventArgs e)
        {
            Dominio.Municipalidad municipalidad = new Dominio.Municipalidad();
            List<Dominio.Autor> unAutor = municipalidad.AutorConMasLibrosVend();
            this.lstConsulta2.DataSource = null;
                this.lstConsulta2.DataSource = municipalidad.AutorConMasLibrosVend();
            
        }

        private void btnConsulta3_Click(object sender, EventArgs e)
        {
            Dominio.Municipalidad municipalidad = new Dominio.Municipalidad();
            List<Dominio.Libro> unLibro = municipalidad.LibroConMasVent();
            this.lstConsulta3.DataSource = null;
            this.lstConsulta3.DataSource = municipalidad.LibroConMasVent();
        }

        private void btnConsulta4_Click(object sender, EventArgs e)
        {
            Dominio.Municipalidad municipalidad = new Dominio.Municipalidad();
            string Nombre = this.txtNombre.Text;
            this.lstConsulta4.DataSource = null;
            List<Dominio.Venta> unVenta = municipalidad.LectorDadoNom(Nombre);
            if (unVenta.Count != 0)
            {
                this.lstConsulta4.DataSource = municipalidad.LectorDadoNom(Nombre);
            }
            else
            {
                this.lstConsulta4.Items.Remove("No hay compras de este lector");
                this.lstConsulta4.Items.Add("No hay compras de este lector");
            }    
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }


    
}
