
namespace Obligatorio1octubre.Presentacion
{
    partial class frmPersonas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.rbdLectores = new System.Windows.Forms.RadioButton();
            this.rbdAutor = new System.Windows.Forms.RadioButton();
            this.gbpAutor = new System.Windows.Forms.GroupBox();
            this.txtFallecido = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxFallecido = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dteFechaDeNac = new System.Windows.Forms.DateTimePicker();
            this.txtNacinalidad = new System.Windows.Forms.TextBox();
            this.lblMensajes = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lstLectores = new System.Windows.Forms.ListBox();
            this.lstAutor = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.gbpAutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRecargar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rbdLectores);
            this.groupBox1.Controls.Add(this.rbdAutor);
            this.groupBox1.Controls.Add(this.gbpAutor);
            this.groupBox1.Controls.Add(this.lblMensajes);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnBaja);
            this.groupBox1.Controls.Add(this.btnAlta);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(4, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 391);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(347, 298);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(75, 23);
            this.btnRecargar.TabIndex = 24;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "¿Qué desea añadir?";
            // 
            // rbdLectores
            // 
            this.rbdLectores.AutoSize = true;
            this.rbdLectores.Location = new System.Drawing.Point(197, 29);
            this.rbdLectores.Name = "rbdLectores";
            this.rbdLectores.Size = new System.Drawing.Size(58, 19);
            this.rbdLectores.TabIndex = 20;
            this.rbdLectores.Text = "Lector";
            this.rbdLectores.UseVisualStyleBackColor = true;
            this.rbdLectores.CheckedChanged += new System.EventHandler(this.rbdLectores_CheckedChanged);
            // 
            // rbdAutor
            // 
            this.rbdAutor.AutoSize = true;
            this.rbdAutor.Checked = true;
            this.rbdAutor.Location = new System.Drawing.Point(281, 29);
            this.rbdAutor.Name = "rbdAutor";
            this.rbdAutor.Size = new System.Drawing.Size(55, 19);
            this.rbdAutor.TabIndex = 19;
            this.rbdAutor.TabStop = true;
            this.rbdAutor.Text = "Autor";
            this.rbdAutor.UseVisualStyleBackColor = true;
            this.rbdAutor.CheckedChanged += new System.EventHandler(this.rdbAutor_CheckedChanged);
            // 
            // gbpAutor
            // 
            this.gbpAutor.Controls.Add(this.txtFallecido);
            this.gbpAutor.Controls.Add(this.label10);
            this.gbpAutor.Controls.Add(this.cbxFallecido);
            this.gbpAutor.Controls.Add(this.label4);
            this.gbpAutor.Controls.Add(this.label5);
            this.gbpAutor.Controls.Add(this.label6);
            this.gbpAutor.Controls.Add(this.dteFechaDeNac);
            this.gbpAutor.Controls.Add(this.txtNacinalidad);
            this.gbpAutor.Location = new System.Drawing.Point(14, 150);
            this.gbpAutor.Name = "gbpAutor";
            this.gbpAutor.Size = new System.Drawing.Size(385, 130);
            this.gbpAutor.TabIndex = 18;
            this.gbpAutor.TabStop = false;
            // 
            // txtFallecido
            // 
            this.txtFallecido.Enabled = false;
            this.txtFallecido.Location = new System.Drawing.Point(182, 92);
            this.txtFallecido.Name = "txtFallecido";
            this.txtFallecido.Size = new System.Drawing.Size(200, 23);
            this.txtFallecido.TabIndex = 14;
            this.txtFallecido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFallecido_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(97, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Fallecido";
            // 
            // cbxFallecido
            // 
            this.cbxFallecido.AutoSize = true;
            this.cbxFallecido.Location = new System.Drawing.Point(183, 44);
            this.cbxFallecido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxFallecido.Name = "cbxFallecido";
            this.cbxFallecido.Size = new System.Drawing.Size(15, 14);
            this.cbxFallecido.TabIndex = 12;
            this.cbxFallecido.UseVisualStyleBackColor = true;
            this.cbxFallecido.CheckedChanged += new System.EventHandler(this.cbxFallecido_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de fallecimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nacionalidad";
            // 
            // dteFechaDeNac
            // 
            this.dteFechaDeNac.CustomFormat = "yyyy";
            this.dteFechaDeNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dteFechaDeNac.Location = new System.Drawing.Point(182, 63);
            this.dteFechaDeNac.Name = "dteFechaDeNac";
            this.dteFechaDeNac.Size = new System.Drawing.Size(200, 23);
            this.dteFechaDeNac.TabIndex = 10;
            // 
            // txtNacinalidad
            // 
            this.txtNacinalidad.Location = new System.Drawing.Point(182, 11);
            this.txtNacinalidad.Name = "txtNacinalidad";
            this.txtNacinalidad.Size = new System.Drawing.Size(200, 23);
            this.txtNacinalidad.TabIndex = 9;
            this.txtNacinalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNacinalidad_KeyPress);
            // 
            // lblMensajes
            // 
            this.lblMensajes.AutoSize = true;
            this.lblMensajes.Location = new System.Drawing.Point(63, 352);
            this.lblMensajes.Name = "lblMensajes";
            this.lblMensajes.Size = new System.Drawing.Size(0, 15);
            this.lblMensajes.TabIndex = 17;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(266, 298);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(173, 298);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 23);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(86, 298);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(81, 23);
            this.btnBaja.TabIndex = 13;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(6, 298);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAlta.TabIndex = 12;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(196, 121);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(200, 23);
            this.txtApellido.TabIndex = 8;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(196, 92);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 23);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(196, 62);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(200, 23);
            this.txtId.TabIndex = 6;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(473, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "Lectores";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(476, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Autores";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lstLectores
            // 
            this.lstLectores.FormattingEnabled = true;
            this.lstLectores.ItemHeight = 15;
            this.lstLectores.Location = new System.Drawing.Point(434, 245);
            this.lstLectores.Name = "lstLectores";
            this.lstLectores.Size = new System.Drawing.Size(219, 154);
            this.lstLectores.TabIndex = 24;
            this.lstLectores.Click += new System.EventHandler(this.lstLectores_Click_1);
            // 
            // lstAutor
            // 
            this.lstAutor.FormattingEnabled = true;
            this.lstAutor.ItemHeight = 15;
            this.lstAutor.Location = new System.Drawing.Point(434, 61);
            this.lstAutor.Name = "lstAutor";
            this.lstAutor.Size = new System.Drawing.Size(219, 154);
            this.lstAutor.TabIndex = 25;
            this.lstAutor.Click += new System.EventHandler(this.lstAutor_Click_1);
            // 
            // frmPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 431);
            this.Controls.Add(this.lstLectores);
            this.Controls.Add(this.lstAutor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Name = "frmPersonas";
            this.Text = "Personas";
            this.Load += new System.EventHandler(this.frmAutor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbpAutor.ResumeLayout(false);
            this.gbpAutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.DateTimePicker dteFechaDeNac;
        private System.Windows.Forms.TextBox txtNacinalidad;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lblMensajes;
        private System.Windows.Forms.RadioButton rbdLectores;
        private System.Windows.Forms.RadioButton rbdAutor;
        private System.Windows.Forms.GroupBox gbpAutor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbxFallecido;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lstLectores;
        private System.Windows.Forms.ListBox lstAutor;
        private System.Windows.Forms.TextBox txtFallecido;
        private System.Windows.Forms.Button btnRecargar;
    }
}