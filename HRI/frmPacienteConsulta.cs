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
    public partial class frmPacienteConsulta : Form
    {
        private frmPrincipal FrmPrincipal;
        public frmPacienteConsulta(frmPrincipal FrmPrincipal)
        {
            InitializeComponent();
            this.FrmPrincipal = FrmPrincipal;
        }

        private void frmPacienteConsulta_LocationChanged(object sender, EventArgs e)
        {
            consulta();
        }

        public void consulta()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select IPaciente as Id,NroDocumento as Documento,(ApellidoPaterno +' '+ ApellidoMaterno +' '+ PrimerNombre +' '+ SegundoNombre) as Paciente,IdNroHistoriaClinica as HCL,FechaNacimiento as FNacimiento from Paciente where IdEstado = '1'", FrmPrincipal.Cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            //Dimensionar un datagrid
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].Width = 220;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 85;
            //Tipo de centrado al datagrid
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
        }
    }
}
