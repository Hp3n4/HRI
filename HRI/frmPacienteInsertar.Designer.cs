namespace HRI
{
    partial class frmPacienteInsertar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPacienteInsertar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNroHistoriaClinica = new System.Windows.Forms.TextBox();
            this.lblNroHistoriaClinica = new System.Windows.Forms.Label();
            this.cmbHistoriaClinica = new System.Windows.Forms.ComboBox();
            this.lblHistoriaClinica = new System.Windows.Forms.Label();
            this.lblNroDocumento = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtPaterno = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.lblSegundoNombre = new System.Windows.Forms.Label();
            this.lblPrimerNombre = new System.Windows.Forms.Label();
            this.txtMaterno = new System.Windows.Forms.TextBox();
            this.lblMaterno = new System.Windows.Forms.Label();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtNroHistoriaClinica);
            this.groupBox1.Controls.Add(this.lblNroHistoriaClinica);
            this.groupBox1.Controls.Add(this.cmbHistoriaClinica);
            this.groupBox1.Controls.Add(this.lblHistoriaClinica);
            this.groupBox1.Controls.Add(this.lblNroDocumento);
            this.groupBox1.Controls.Add(this.cmbTipoDocumento);
            this.groupBox1.Controls.Add(this.lblTipoDocumento);
            this.groupBox1.Controls.Add(this.txtNroDocumento);
            this.groupBox1.Location = new System.Drawing.Point(57, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nro Documento";
            // 
            // txtNroHistoriaClinica
            // 
            this.txtNroHistoriaClinica.Enabled = false;
            this.txtNroHistoriaClinica.Location = new System.Drawing.Point(259, 72);
            this.txtNroHistoriaClinica.Name = "txtNroHistoriaClinica";
            this.txtNroHistoriaClinica.Size = new System.Drawing.Size(127, 26);
            this.txtNroHistoriaClinica.TabIndex = 4;
            // 
            // lblNroHistoriaClinica
            // 
            this.lblNroHistoriaClinica.AutoSize = true;
            this.lblNroHistoriaClinica.Location = new System.Drawing.Point(183, 75);
            this.lblNroHistoriaClinica.Name = "lblNroHistoriaClinica";
            this.lblNroHistoriaClinica.Size = new System.Drawing.Size(61, 20);
            this.lblNroHistoriaClinica.TabIndex = 6;
            this.lblNroHistoriaClinica.Text = "Nro HC";
            // 
            // cmbHistoriaClinica
            // 
            this.cmbHistoriaClinica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHistoriaClinica.FormattingEnabled = true;
            this.cmbHistoriaClinica.Location = new System.Drawing.Point(76, 71);
            this.cmbHistoriaClinica.Name = "cmbHistoriaClinica";
            this.cmbHistoriaClinica.Size = new System.Drawing.Size(91, 28);
            this.cmbHistoriaClinica.TabIndex = 3;
            this.cmbHistoriaClinica.SelectionChangeCommitted += new System.EventHandler(this.cmbHistoriaClinica_SelectionChangeCommitted);
            // 
            // lblHistoriaClinica
            // 
            this.lblHistoriaClinica.AutoSize = true;
            this.lblHistoriaClinica.Location = new System.Drawing.Point(-2, 75);
            this.lblHistoriaClinica.Name = "lblHistoriaClinica";
            this.lblHistoriaClinica.Size = new System.Drawing.Size(63, 20);
            this.lblHistoriaClinica.TabIndex = 4;
            this.lblHistoriaClinica.Text = "Tipo HC";
            // 
            // lblNroDocumento
            // 
            this.lblNroDocumento.AutoSize = true;
            this.lblNroDocumento.Location = new System.Drawing.Point(183, 43);
            this.lblNroDocumento.Name = "lblNroDocumento";
            this.lblNroDocumento.Size = new System.Drawing.Size(70, 20);
            this.lblNroDocumento.TabIndex = 2;
            this.lblNroDocumento.Text = "Nro Doc";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(76, 39);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(91, 28);
            this.cmbTipoDocumento.TabIndex = 1;
            this.cmbTipoDocumento.SelectionChangeCommitted += new System.EventHandler(this.cmbTipoDocumento_SelectionChangeCommitted);
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(-2, 43);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(72, 20);
            this.lblTipoDocumento.TabIndex = 0;
            this.lblTipoDocumento.Text = "Tipo Doc";
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(259, 40);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(127, 26);
            this.txtNroDocumento.TabIndex = 2;
            this.txtNroDocumento.TextChanged += new System.EventHandler(this.txtNroDocumento_TextChanged);
            this.txtNroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroDocumento_KeyPress);
            // 
            // gbDatos
            // 
            this.gbDatos.BackColor = System.Drawing.Color.Transparent;
            this.gbDatos.Controls.Add(this.dtpFechaNacimiento);
            this.gbDatos.Controls.Add(this.lblFechaNacimiento);
            this.gbDatos.Controls.Add(this.txtPrimerNombre);
            this.gbDatos.Controls.Add(this.txtPaterno);
            this.gbDatos.Controls.Add(this.txtSegundoNombre);
            this.gbDatos.Controls.Add(this.lblSegundoNombre);
            this.gbDatos.Controls.Add(this.lblPrimerNombre);
            this.gbDatos.Controls.Add(this.txtMaterno);
            this.gbDatos.Controls.Add(this.lblMaterno);
            this.gbDatos.Controls.Add(this.lblApellidoPaterno);
            this.gbDatos.Location = new System.Drawing.Point(14, 128);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(501, 126);
            this.gbDatos.TabIndex = 8;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(118, 89);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(102, 26);
            this.dtpFechaNacimiento.TabIndex = 9;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(-2, 92);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(114, 20);
            this.lblFechaNacimiento.TabIndex = 10;
            this.lblFechaNacimiento.Text = "Fe Nacimiento";
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Location = new System.Drawing.Point(93, 57);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(127, 26);
            this.txtPrimerNombre.TabIndex = 7;
            // 
            // txtPaterno
            // 
            this.txtPaterno.Location = new System.Drawing.Point(93, 25);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(127, 26);
            this.txtPaterno.TabIndex = 5;
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Location = new System.Drawing.Point(368, 57);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(127, 26);
            this.txtSegundoNombre.TabIndex = 8;
            // 
            // lblSegundoNombre
            // 
            this.lblSegundoNombre.AutoSize = true;
            this.lblSegundoNombre.Location = new System.Drawing.Point(253, 60);
            this.lblSegundoNombre.Name = "lblSegundoNombre";
            this.lblSegundoNombre.Size = new System.Drawing.Size(99, 20);
            this.lblSegundoNombre.TabIndex = 6;
            this.lblSegundoNombre.Text = "Seg Nombre";
            // 
            // lblPrimerNombre
            // 
            this.lblPrimerNombre.AutoSize = true;
            this.lblPrimerNombre.Location = new System.Drawing.Point(-2, 60);
            this.lblPrimerNombre.Name = "lblPrimerNombre";
            this.lblPrimerNombre.Size = new System.Drawing.Size(89, 20);
            this.lblPrimerNombre.TabIndex = 4;
            this.lblPrimerNombre.Text = "Pri Nombre";
            // 
            // txtMaterno
            // 
            this.txtMaterno.Location = new System.Drawing.Point(368, 25);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(127, 26);
            this.txtMaterno.TabIndex = 6;
            // 
            // lblMaterno
            // 
            this.lblMaterno.AutoSize = true;
            this.lblMaterno.Location = new System.Drawing.Point(253, 28);
            this.lblMaterno.Name = "lblMaterno";
            this.lblMaterno.Size = new System.Drawing.Size(73, 20);
            this.lblMaterno.TabIndex = 2;
            this.lblMaterno.Text = "Materno";
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Location = new System.Drawing.Point(-2, 28);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(67, 20);
            this.lblApellidoPaterno.TabIndex = 0;
            this.lblApellidoPaterno.Text = "Paterno";
            // 
            // button1
            // 
            this.button1.Image = global::HRI.Properties.Resources.disquete;
            this.button1.Location = new System.Drawing.Point(188, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 81);
            this.button1.TabIndex = 9;
            this.button1.Text = "Guardar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPacienteInsertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HRI.Properties.Resources.head_bg28;
            this.ClientSize = new System.Drawing.Size(527, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmPacienteInsertar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Registro Paciente";
            this.Load += new System.EventHandler(this.frmPacienteInsertar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNroHistoriaClinica;
        private System.Windows.Forms.Label lblNroHistoriaClinica;
        private System.Windows.Forms.ComboBox cmbHistoriaClinica;
        private System.Windows.Forms.Label lblHistoriaClinica;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.Label lblNroDocumento;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.TextBox txtPaterno;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.Label lblSegundoNombre;
        private System.Windows.Forms.Label lblPrimerNombre;
        private System.Windows.Forms.TextBox txtMaterno;
        private System.Windows.Forms.Label lblMaterno;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Button button1;
    }
}