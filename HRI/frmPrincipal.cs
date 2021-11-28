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
    public partial class frmPrincipal : Form
    {
        public SqlConnection Cn;
        private frmPacienteConsulta FrmPacienteConsulta = null;
        
        public frmPrincipal()
        {
            InitializeComponent();
            Cn = new SqlConnection("Data Source=(local);Initial Catalog=HRI;Integrated Security=SSPI;");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmPacienteConsulta))
                {
                    form.Activate();
                    return;
                }
            }

            frmPacienteConsulta FrmPacienteConsulta = new frmPacienteConsulta(this);
            FrmPacienteConsulta.MdiParent = this;
            FrmPacienteConsulta.Show();
            FrmPacienteConsulta.BringToFront();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPacienteInsertar FrmPacienteInsertar = new frmPacienteInsertar(this, FrmPacienteConsulta);
            FrmPacienteInsertar.MdiParent = this;
            FrmPacienteInsertar.Show();
        }
    }
}
