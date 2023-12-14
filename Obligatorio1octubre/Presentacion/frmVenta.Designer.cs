
namespace Obligatorio1octubre.Presentacion
{
    partial class frmVenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dtpFechaVe = new System.Windows.Forms.DateTimePicker();
            this.lstLibros = new System.Windows.Forms.ListBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.cbxLector = new System.Windows.Forms.ComboBox();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.lblMensajes = new System.Windows.Forms.Label();
            this.lstVentas = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Titulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Autor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lector";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(122, 41);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(219, 23);
            this.txtId.TabIndex = 5;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // dtpFechaVe
            // 
            this.dtpFechaVe.Location = new System.Drawing.Point(122, 77);
            this.dtpFechaVe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaVe.Name = "dtpFechaVe";
            this.dtpFechaVe.Size = new System.Drawing.Size(219, 23);
            this.dtpFechaVe.TabIndex = 7;
            // 
            // lstLibros
            // 
            this.lstLibros.FormattingEnabled = true;
            this.lstLibros.ItemHeight = 15;
            this.lstLibros.Location = new System.Drawing.Point(122, 136);
            this.lstLibros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstLibros.Name = "lstLibros";
            this.lstLibros.Size = new System.Drawing.Size(219, 109);
            this.lstLibros.TabIndex = 8;
            this.lstLibros.Click += new System.EventHandler(this.lstLibros_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(122, 112);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(219, 23);
            this.txtTitulo.TabIndex = 9;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            this.txtTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTitulo_KeyPress);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(375, 309);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(82, 22);
            this.btnAlta.TabIndex = 13;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtAutor
            // 
            this.txtAutor.Enabled = false;
            this.txtAutor.Location = new System.Drawing.Point(122, 259);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(219, 23);
            this.txtAutor.TabIndex = 10;
            // 
            // cbxLector
            // 
            this.cbxLector.FormattingEnabled = true;
            this.cbxLector.Location = new System.Drawing.Point(121, 296);
            this.cbxLector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxLector.Name = "cbxLector";
            this.cbxLector.Size = new System.Drawing.Size(219, 23);
            this.cbxLector.TabIndex = 14;
            this.cbxLector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxLector_KeyPress);
            // 
            // txtLibro
            // 
            this.txtLibro.Enabled = false;
            this.txtLibro.Location = new System.Drawing.Point(122, 329);
            this.txtLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.Size = new System.Drawing.Size(219, 23);
            this.txtLibro.TabIndex = 15;
            // 
            // lblMensajes
            // 
            this.lblMensajes.AutoSize = true;
            this.lblMensajes.Location = new System.Drawing.Point(389, 340);
            this.lblMensajes.Name = "lblMensajes";
            this.lblMensajes.Size = new System.Drawing.Size(0, 15);
            this.lblMensajes.TabIndex = 16;
            // 
            // lstVentas
            // 
            this.lstVentas.FormattingEnabled = true;
            this.lstVentas.ItemHeight = 15;
            this.lstVentas.Location = new System.Drawing.Point(375, 61);
            this.lstVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstVentas.Name = "lstVentas";
            this.lstVentas.Size = new System.Drawing.Size(346, 244);
            this.lstVentas.TabIndex = 17;
            this.lstVentas.Click += new System.EventHandler(this.lstVentas_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(531, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ventas";
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(463, 309);
            this.btnBaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(82, 22);
            this.btnBaja.TabIndex = 19;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(551, 309);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(82, 22);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(639, 309);
            this.btnRecargar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(82, 22);
            this.btnRecargar.TabIndex = 21;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Libro";
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstVentas);
            this.Controls.Add(this.lblMensajes);
            this.Controls.Add(this.txtLibro);
            this.Controls.Add(this.cbxLector);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lstLibros);
            this.Controls.Add(this.dtpFechaVe);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmVenta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DateTimePicker dtpFechaVe;
        private System.Windows.Forms.ListBox lstLibros;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.ComboBox cbxLector;
        private System.Windows.Forms.TextBox txtLibro;
        private System.Windows.Forms.Label lblMensajes;
        private System.Windows.Forms.ListBox lstVentas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Label label6;
    }
}