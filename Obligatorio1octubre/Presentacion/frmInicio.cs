using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Obligatorio1octubre.Presentacion
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        private void Singleton(string pNombreForm)
        {
            bool encontre = false;
            foreach (Form unFrm in this.MdiChildren)
            {
                if (unFrm.Name.Equals(pNombreForm))
                {
                    encontre = true;
                    unFrm.Show();

                }
            }
            if (!encontre)
            {
                switch (pNombreForm)
                {
                    case "frmPersonas":
                        Presentacion.frmPersonas unFrmA = new Presentacion.frmPersonas();
                        unFrmA.MdiParent = this;
                        unFrmA.Show();
                        break;
                        
                 

                    case "frmVenta":
                        Presentacion.frmVenta unfrmV = new Presentacion.frmVenta();
                        unfrmV.MdiParent = this;
                        unfrmV.Show();
                        break;

                    case "frmLibro":
                        Presentacion.frmLibro unfrmLi = new Presentacion.frmLibro();
                        unfrmLi.MdiParent = this;
                        unfrmLi.Show();
                        break;

                    case "frmEstadisticas":
                        Presentacion.frmEstadisticas unFrmE = new Presentacion.frmEstadisticas();
                        unFrmE.MdiParent = this;
                        unFrmE.Show();
                        break;




                }
            }
        }



        private void mnuLibros_Click(object sender, EventArgs e)
        {
            string nombreFrm = "frmLibro";
            this.Singleton(nombreFrm);
        }

        private void mnuVenta_Click(object sender, EventArgs e)
        {
            string nombreFrm = "frmVenta";
            this.Singleton(nombreFrm);
        }

        private void mnuAutores_Click(object sender, EventArgs e)
        {
            string nombreFrm = "frmPersonas";
            this.Singleton(nombreFrm);

        }

        private void mnuEstadisticas_Click(object sender, EventArgs e)
        {
            string nombreFrm = "frmEstadisticas";
                this.Singleton(nombreFrm);
        }
    }
}
