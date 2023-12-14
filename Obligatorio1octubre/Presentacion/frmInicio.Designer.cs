
namespace Obligatorio1octubre.Presentacion
{
    partial class frmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPersonas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEstadisticas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPersonas,
            this.mnuLibros,
            this.mnuVenta,
            this.mnuEstadisticas,
            this.mnuSalir1});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // mnuPersonas
            // 
            this.mnuPersonas.Name = "mnuPersonas";
            this.mnuPersonas.Size = new System.Drawing.Size(180, 22);
            this.mnuPersonas.Text = "ABM de Personas";
            this.mnuPersonas.Click += new System.EventHandler(this.mnuAutores_Click);
            // 
            // mnuLibros
            // 
            this.mnuLibros.Name = "mnuLibros";
            this.mnuLibros.Size = new System.Drawing.Size(180, 22);
            this.mnuLibros.Text = "ABM de Libros";
            this.mnuLibros.Click += new System.EventHandler(this.mnuLibros_Click);
            // 
            // mnuVenta
            // 
            this.mnuVenta.Name = "mnuVenta";
            this.mnuVenta.Size = new System.Drawing.Size(180, 22);
            this.mnuVenta.Text = "ABM de Venta";
            this.mnuVenta.Click += new System.EventHandler(this.mnuVenta_Click);
            // 
            // mnuEstadisticas
            // 
            this.mnuEstadisticas.Name = "mnuEstadisticas";
            this.mnuEstadisticas.Size = new System.Drawing.Size(180, 22);
            this.mnuEstadisticas.Text = "Estadisticas";
            this.mnuEstadisticas.Click += new System.EventHandler(this.mnuEstadisticas_Click);
            // 
            // mnuSalir1
            // 
            this.mnuSalir1.Name = "mnuSalir1";
            this.mnuSalir1.Size = new System.Drawing.Size(180, 22);
            this.mnuSalir1.Text = "Salir";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmInicio";
            this.Text = "frmInicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPersonas;
        private System.Windows.Forms.ToolStripMenuItem mnuLibros;
        private System.Windows.Forms.ToolStripMenuItem mnuVenta;
        private System.Windows.Forms.ToolStripMenuItem mnuEstadisticas;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir1;
    }
}