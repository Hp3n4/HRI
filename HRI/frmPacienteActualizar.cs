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
    public partial class frmPacienteActualizar : Form
    {
        private frmPrincipal FrmPrincipal;
        private frmPacienteConsulta FrmPacienteConsulta;
        public frmPacienteActualizar(frmPrincipal FrmPrincipal, frmPacienteConsulta FrmPacienteConsulta)
        {
            InitializeComponent();
            this.FrmPrincipal = FrmPrincipal;
            this.FrmPacienteConsulta = FrmPacienteConsulta;
        }
        
        private void CargarPaciente()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select IPaciente,(ApellidoPaterno +' '+ ApellidoMaterno +' '+ PrimerNombre +' '+ SegundoNombre) as Paciente from Paciente where IdEstado = '1'", FrmPrincipal.Cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmbPaciente.DataSource = ds.Tables[0];
            cmbPaciente.ValueMember = "IPaciente";
            cmbPaciente.DisplayMember = "Paciente";            
        }

        private void pintaDatos()
        {
            if (cmbPaciente.SelectedIndex != -1)
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT IPaciente, ApellidoPaterno, ApellidoMaterno, PrimerNombre, SegundoNombre, FechaNacimiento,"
                  + " NroDocumento, IdtipoDocumento, IdNroHistoriaClinica,"
                  + "IdTipoNroHistoriaClinica FROM Paciente where IPaciente =" +cmbPaciente.SelectedValue, FrmPrincipal.Cn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataRow row = ds.Tables[0].Select().ElementAt(0);
                txtPaterno.Text = row["ApellidoPaterno"].ToString().Trim();
                txtMaterno.Text = row["ApellidoMaterno"].ToString().Trim();
                txtPrimerNombre.Text = row["PrimerNombre"].ToString().Trim();
                txtSegundoNombre.Text = row["SegudoNombre"].ToString().Trim();
                dtpFechaNacimiento.Value.Date = row["ApellidoPaterno"].ToString().Trim();
            }
            else
            {
                MessageBox.Show("Seleccione Alumno.");
            }
        }
        private void txtNroDocumento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
