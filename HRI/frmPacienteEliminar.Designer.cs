namespace HRI
{
    partial class frmPacienteEliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPacienteEliminar));
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.rdbDatos = new System.Windows.Forms.RadioButton();
            this.rdbNroDocumento = new System.Windows.Forms.RadioButton();
            this.cmbFiltrar = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFiltro
            // 
            this.gbFiltro.BackColor = System.Drawing.Color.Transparent;
            this.gbFiltro.Controls.Add(this.rdbDatos);
            this.gbFiltro.Controls.Add(this.rdbNroDocumento);
            this.gbFiltro.Location = new System.Drawing.Point(12, 12);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(392, 65);
            this.gbFiltro.TabIndex = 0;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Filtro";
            // 
            // rdbDatos
            // 
            this.rdbDatos.AutoSize = true;
            this.rdbDatos.Location = new System.Drawing.Point(269, 25);
            this.rdbDatos.Name = "rdbDatos";
            this.rdbDatos.Size = new System.Drawing.Size(72, 24);
            this.rdbDatos.TabIndex = 1;
            this.rdbDatos.TabStop = true;
            this.rdbDatos.Text = "Datos";
            this.rdbDatos.UseVisualStyleBackColor = true;
            this.rdbDatos.CheckedChanged += new System.EventHandler(this.rdbDatos_CheckedChanged);
            // 
            // rdbNroDocumento
            // 
            this.rdbNroDocumento.AutoSize = true;
            this.rdbNroDocumento.Location = new System.Drawing.Point(6, 25);
            this.rdbNroDocumento.Name = "rdbNroDocumento";
            this.rdbNroDocumento.Size = new System.Drawing.Size(143, 24);
            this.rdbNroDocumento.TabIndex = 0;
            this.rdbNroDocumento.TabStop = true;
            this.rdbNroDocumento.Text = "NroDocuemnto";
            this.rdbNroDocumento.UseVisualStyleBackColor = true;
            this.rdbNroDocumento.CheckedChanged += new System.EventHandler(this.rdbNroDocumento_CheckedChanged);
            // 
            // cmbFiltrar
            // 
            this.cmbFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrar.FormattingEnabled = true;
            this.cmbFiltrar.Location = new System.Drawing.Point(18, 83);
            this.cmbFiltrar.Name = "cmbFiltrar";
            this.cmbFiltrar.Size = new System.Drawing.Size(386, 28);
            this.cmbFiltrar.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::HRI.Properties.Resources.basura;
            this.btnEliminar.Location = new System.Drawing.Point(137, 141);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(148, 78);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar Registro";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmPacienteEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HRI.Properties.Resources.head_bg28;
            this.ClientSize = new System.Drawing.Size(416, 231);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.cmbFiltrar);
            this.Controls.Add(this.gbFiltro);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmPacienteEliminar";
            this.Text = "Expulsar Paciente";
            this.Load += new System.EventHandler(this.frmPacienteEliminar_Load);
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.RadioButton rdbDatos;
        private System.Windows.Forms.RadioButton rdbNroDocumento;
        private System.Windows.Forms.ComboBox cmbFiltrar;
        private System.Windows.Forms.Button btnEliminar;
    }
}