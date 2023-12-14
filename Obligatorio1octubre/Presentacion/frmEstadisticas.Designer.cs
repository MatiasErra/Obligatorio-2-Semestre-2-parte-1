
namespace Obligatorio1octubre.Presentacion
{
    partial class frmEstadisticas
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
            this.lblConsulta1 = new System.Windows.Forms.Label();
            this.btnConsulta1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsulta2 = new System.Windows.Forms.Button();
            this.lstConsulta2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsulta3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstConsulta3 = new System.Windows.Forms.ListBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstConsulta4 = new System.Windows.Forms.ListBox();
            this.btnConsulta4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConsulta1
            // 
            this.lblConsulta1.AutoSize = true;
            this.lblConsulta1.Location = new System.Drawing.Point(93, 28);
            this.lblConsulta1.Name = "lblConsulta1";
            this.lblConsulta1.Size = new System.Drawing.Size(16, 15);
            this.lblConsulta1.TabIndex = 0;
            this.lblConsulta1.Text = "...";
            // 
            // btnConsulta1
            // 
            this.btnConsulta1.Location = new System.Drawing.Point(12, 24);
            this.btnConsulta1.Name = "btnConsulta1";
            this.btnConsulta1.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta1.TabIndex = 1;
            this.btnConsulta1.Text = "Consulta1";
            this.btnConsulta1.UseVisualStyleBackColor = true;
            this.btnConsulta1.Click += new System.EventHandler(this.btnConsulta1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "1) Reporte de la recaudación total";
            // 
            // btnConsulta2
            // 
            this.btnConsulta2.Location = new System.Drawing.Point(12, 78);
            this.btnConsulta2.Name = "btnConsulta2";
            this.btnConsulta2.Size = new System.Drawing.Size(75, 24);
            this.btnConsulta2.TabIndex = 3;
            this.btnConsulta2.Text = "Consulta 3 ";
            this.btnConsulta2.UseVisualStyleBackColor = true;
            this.btnConsulta2.Click += new System.EventHandler(this.btnConsulta2_Click);
            // 
            // lstConsulta2
            // 
            this.lstConsulta2.FormattingEnabled = true;
            this.lstConsulta2.ItemHeight = 15;
            this.lstConsulta2.Location = new System.Drawing.Point(93, 78);
            this.lstConsulta2.Name = "lstConsulta2";
            this.lstConsulta2.Size = new System.Drawing.Size(143, 109);
            this.lstConsulta2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "3) Mostrar el autor/res que vendieron más libros.";
            // 
            // btnConsulta3
            // 
            this.btnConsulta3.Location = new System.Drawing.Point(12, 208);
            this.btnConsulta3.Name = "btnConsulta3";
            this.btnConsulta3.Size = new System.Drawing.Size(75, 24);
            this.btnConsulta3.TabIndex = 6;
            this.btnConsulta3.Text = "Consulta 4";
            this.btnConsulta3.UseVisualStyleBackColor = true;
            this.btnConsulta3.Click += new System.EventHandler(this.btnConsulta3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "4) Mostrar el/los libros más vendidos";
            // 
            // lstConsulta3
            // 
            this.lstConsulta3.FormattingEnabled = true;
            this.lstConsulta3.ItemHeight = 15;
            this.lstConsulta3.Location = new System.Drawing.Point(93, 208);
            this.lstConsulta3.Name = "lstConsulta3";
            this.lstConsulta3.Size = new System.Drawing.Size(143, 109);
            this.lstConsulta3.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(343, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "5) Dado un lector mostrar los títulos de los libros que compró";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lstConsulta4
            // 
            this.lstConsulta4.FormattingEnabled = true;
            this.lstConsulta4.ItemHeight = 15;
            this.lstConsulta4.Location = new System.Drawing.Point(449, 78);
            this.lstConsulta4.Name = "lstConsulta4";
            this.lstConsulta4.Size = new System.Drawing.Size(224, 139);
            this.lstConsulta4.TabIndex = 11;
            // 
            // btnConsulta4
            // 
            this.btnConsulta4.Location = new System.Drawing.Point(354, 109);
            this.btnConsulta4.Name = "btnConsulta4";
            this.btnConsulta4.Size = new System.Drawing.Size(75, 24);
            this.btnConsulta4.TabIndex = 12;
            this.btnConsulta4.Text = "Consulta 5";
            this.btnConsulta4.UseVisualStyleBackColor = true;
            this.btnConsulta4.Click += new System.EventHandler(this.btnConsulta4_Click);
            // 
            // frmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConsulta4);
            this.Controls.Add(this.lstConsulta4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lstConsulta3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConsulta3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstConsulta2);
            this.Controls.Add(this.btnConsulta2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsulta1);
            this.Controls.Add(this.lblConsulta1);
            this.Name = "frmEstadisticas";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.frmEstadisticas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsulta1;
        private System.Windows.Forms.Button btnConsulta1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsulta2;
        private System.Windows.Forms.ListBox lstConsulta2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConsulta3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstConsulta3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstConsulta4;
        private System.Windows.Forms.Button btnConsulta4;
    }
}