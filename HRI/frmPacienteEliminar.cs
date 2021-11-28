using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HRI
{
    public partial class frmPacienteEliminar : Form
    {
        private frmPrincipal FrmPrincipal;
        private frmPacienteConsulta FrmPacienteConsulta; 
        public frmPacienteEliminar(frmPrincipal FrmPrincipal, frmPacienteConsulta FrmPacienteConsulta)
        {
            InitializeComponent();

            this.FrmPrincipal = FrmPrincipal;
            this.FrmPacienteConsulta = FrmPacienteConsulta;
        }

        private void CargarDatosPaciente()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select IPaciente,(ApellidoPaterno +' '+ ApellidoMaterno +' '+ PrimerNombre +' '+ SegundoNombre) as Paciente from Paciente where IdEstado = '1'", FrmPrincipal.Cn);
            DataSet ds = new DataSet();

            da.Fill(ds);
            cmbFiltrar.DataSource = ds.Tables[0];
            cmbFiltrar.ValueMember = "IPaciente";
            cmbFiltrar.DisplayMember = "Paciente";
        }
        //Realizando un select me permite cargar los datos 
        private void CargarDatosNroDocumento()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT IPaciente, NroDocumento FROM Paciente where idestado = '1'", FrmPrincipal.Cn);
            DataSet ds = new DataSet();

            da.Fill(ds);
            cmbFiltrar.DataSource = ds.Tables[0];
            cmbFiltrar.ValueMember = "IPaciente";
            cmbFiltrar.DisplayMember = "NroDocumento";
        }

        private void frmPacienteEliminar_Load(object sender, EventArgs e)
        {
            
            
        }

        private void rdbNroDocumento_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNroDocumento.Checked)
                CargarDatosNroDocumento();
        }

        private void rdbDatos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDatos.Checked)
                CargarDatosPaciente();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbFiltrar.SelectedIndex != -1)
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = FrmPrincipal.Cn;
                cmd.CommandText = "UPDATE paciente SET IdEstado = '0' WHERE IPaciente=" + cmbFiltrar.SelectedValue;
                FrmPrincipal.Cn.Open();
                cmd.ExecuteNonQuery();
                FrmPrincipal.Cn.Close();

                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmPacienteConsulta))
                    {
                        ((frmPacienteConsulta)form).consulta();
                        form.Activate();
                        form.BringToFront();
                    }
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Selecciona algun Registro.");
            }
        }
    }
}
