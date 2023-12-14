
namespace Obligatorio1octubre.Presentacion
{
    partial class frmLibro
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.cbAutor = new System.Windows.Forms.ComboBox();
            this.lstLibros = new System.Windows.Forms.ListBox();
            this.btnAltaLibro = new System.Windows.Forms.Button();
            this.btnBajaLibro = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dtpAño = new System.Windows.Forms.DateTimePicker();
            this.rbdOrden = new System.Windows.Forms.RadioButton();
            this.rbdTitulo = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Título";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Género";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Año";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Autor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Comentario";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(116, 30);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(196, 23);
            this.txtId.TabIndex = 7;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(116, 64);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(196, 23);
            this.txtTitulo.TabIndex = 8;
            this.txtTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTitulo_KeyPress);
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(116, 100);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(196, 23);
            this.txtGenero.TabIndex = 9;
            this.txtGenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGenero_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(116, 199);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(196, 23);
            this.txtPrecio.TabIndex = 12;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(116, 232);
            this.txtComentario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(196, 23);
            this.txtComentario.TabIndex = 13;
            this.txtComentario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComentario_KeyPress);
            // 
            // cbAutor
            // 
            this.cbAutor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbAutor.FormattingEnabled = true;
            this.cbAutor.Location = new System.Drawing.Point(116, 166);
            this.cbAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAutor.Name = "cbAutor";
            this.cbAutor.Size = new System.Drawing.Size(196, 23);
            this.cbAutor.TabIndex = 15;
            this.cbAutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAutor_KeyPress);
            // 
            // lstLibros
            // 
            this.lstLibros.FormattingEnabled = true;
            this.lstLibros.ItemHeight = 15;
            this.lstLibros.Location = new System.Drawing.Point(343, 30);
            this.lstLibros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstLibros.Name = "lstLibros";
            this.lstLibros.Size = new System.Drawing.Size(311, 214);
            this.lstLibros.TabIndex = 16;
            this.lstLibros.Click += new System.EventHandler(this.lstLibros_Click);
            // 
            // btnAltaLibro
            // 
            this.btnAltaLibro.Location = new System.Drawing.Point(12, 287);
            this.btnAltaLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAltaLibro.Name = "btnAltaLibro";
            this.btnAltaLibro.Size = new System.Drawing.Size(82, 22);
            this.btnAltaLibro.TabIndex = 18;
            this.btnAltaLibro.Text = "Alta";
            this.btnAltaLibro.UseVisualStyleBackColor = true;
            this.btnAltaLibro.Click += new System.EventHandler(this.btnAltaLibro_Click);
            // 
            // btnBajaLibro
            // 
            this.btnBajaLibro.Location = new System.Drawing.Point(100, 287);
            this.btnBajaLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBajaLibro.Name = "btnBajaLibro";
            this.btnBajaLibro.Size = new System.Drawing.Size(82, 22);
            this.btnBajaLibro.TabIndex = 19;
            this.btnBajaLibro.Text = "Baja";
            this.btnBajaLibro.UseVisualStyleBackColor = true;
            this.btnBajaLibro.Click += new System.EventHandler(this.btnBajaLibro_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(188, 287);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(82, 22);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dtpAño
            // 
            this.dtpAño.CustomFormat = " yyyy";
            this.dtpAño.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAño.Location = new System.Drawing.Point(116, 135);
            this.dtpAño.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpAño.Name = "dtpAño";
            this.dtpAño.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpAño.Size = new System.Drawing.Size(196, 23);
            this.dtpAño.TabIndex = 21;
            // 
            // rbdOrden
            // 
            this.rbdOrden.AutoSize = true;
            this.rbdOrden.Checked = true;
            this.rbdOrden.Location = new System.Drawing.Point(429, 264);
            this.rbdOrden.Name = "rbdOrden";
            this.rbdOrden.Size = new System.Drawing.Size(64, 19);
            this.rbdOrden.TabIndex = 23;
            this.rbdOrden.TabStop = true;
            this.rbdOrden.Text = "Ingreso";
            this.rbdOrden.UseVisualStyleBackColor = true;
            this.rbdOrden.CheckedChanged += new System.EventHandler(this.rbdOrden_CheckedChanged);
            // 
            // rbdTitulo
            // 
            this.rbdTitulo.AutoSize = true;
            this.rbdTitulo.Location = new System.Drawing.Point(519, 264);
            this.rbdTitulo.Name = "rbdTitulo";
            this.rbdTitulo.Size = new System.Drawing.Size(55, 19);
            this.rbdTitulo.TabIndex = 24;
            this.rbdTitulo.Text = "Titulo";
            this.rbdTitulo.UseVisualStyleBackColor = true;
            this.rbdTitulo.CheckedChanged += new System.EventHandler(this.rbdTitulo_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(466, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Ordenar por: ";
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(461, 288);
            this.btnRecargar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(82, 38);
            this.btnRecargar.TabIndex = 27;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(59, 329);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(16, 15);
            this.lblMensaje.TabIndex = 28;
            this.lblMensaje.Text = "...";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(276, 288);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(82, 22);
            this.btnLimpiar.TabIndex = 29;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // frmLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 353);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rbdTitulo);
            this.Controls.Add(this.rbdOrden);
            this.Controls.Add(this.dtpAño);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBajaLibro);
            this.Controls.Add(this.btnAltaLibro);
            this.Controls.Add(this.lstLibros);
            this.Controls.Add(this.cbAutor);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLibro";
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.frmLibro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.ComboBox cbAutor;
        private System.Windows.Forms.ListBox lstLibros;
        private System.Windows.Forms.Button btnAltaLibro;
        private System.Windows.Forms.Button btnBajaLibro;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DateTimePicker dtpAño;
        private System.Windows.Forms.RadioButton rbdOrden;
        private System.Windows.Forms.RadioButton rbdTitulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnLimpiar;
    }
}