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
    public partial class frmPacienteInsertar : Form
    {
        private frmPrincipal FrmPrincipal;
        private frmPacienteConsulta FrmPacienteConsulta;
        public frmPacienteInsertar()
        {
            InitializeComponent();
        }

        public frmPacienteInsertar(frmPrincipal FrmPrincipal,frmPacienteConsulta FrmPacienteConsulta)
        {
            InitializeComponent();
            this.FrmPrincipal = FrmPrincipal;
            this.FrmPacienteConsulta = FrmPacienteConsulta;
        }

        private void LlenarTipoDocumento()
        {
            SqlDataAdapter da = new SqlDataAdapter("select IdTipoDocumento,Descripcion from TipoDocumento", FrmPrincipal.Cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbTipoDocumento.DataSource = dt;
            cmbTipoDocumento.ValueMember = "IdTipoDocumento";
            cmbTipoDocumento.DisplayMember = "Descripcion";
            cmbTipoDocumento.SelectedIndex = 1;
        }

        private void LlenarTipoHistoriaClinica()
        {
            SqlDataAdapter da = new SqlDataAdapter("select IdTipoNroHistoriaClinica, Descripcion, GenerarNroHistoriaClinica from TipoNroHistoriaClinica", FrmPrincipal.Cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbHistoriaClinica.DataSource = dt;
            cmbHistoriaClinica.ValueMember = "IdTipoNroHistoriaClinica";
            cmbHistoriaClinica.DisplayMember = "Descripcion";
            cmbHistoriaClinica.SelectedIndex = 1;
        }
        private int SoloNumeros (int Tecla)
        {
            switch (Tecla)
            {
                case 48:
                case 49:
                case 50:
                case 51:
                case 52:
                case 53:
                case 54:
                case 55:
                case 56:
                case 57:
                case 46:
                case 08:
                case 13:
                    return Tecla;
                    default:
                    MessageBox.Show("No Ingrese Letra por Favor", "Advertencia de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
            return Tecla = 0;
        }         

        private void frmPacienteInsertar_Load(object sender, EventArgs e)
        {
            LlenarTipoDocumento();
            LlenarTipoHistoriaClinica();
        }

        private void txtNroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(SoloNumeros(e.KeyChar));
        }
        string NroDocumento;
        private void txtNroDocumento_TextChanged(object sender, EventArgs e)
        {
            //NroDocumento = txtNroDocumento.Text;
            //for (int i = 0;i< NroDocumento.Length; i++)
            //{
            //    if (NroDocumento[i] >='0' && NroDocumento[i] <= '8')
            //    {

            //    }
            //    else
            //    {
            //        MessageBox.Show("El Numero Ingresado Excede los 8 Digitos DNI", "Advertencia de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    }
            //}
        }

        private void cmbTipoDocumento_SelectionChangeCommitted(object sender, EventArgs e)
        {
         
        }

        private void cmbHistoriaClinica_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cmbHistoriaClinica.SelectedIndex == 1)
            {
                txtNroHistoriaClinica.Text = txtNroDocumento.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNroDocumento.Text.Trim().Length > 0)
            {
                SqlCommand command = new SqlCommand();

                command.Connection = FrmPrincipal.Cn;
                command.CommandText = "INSERT INTO Paciente	(  ApellidoPaterno,          ApellidoMaterno,          PrimerNombre,                  SegundoNombre,                FechaNacimiento,                                NroDocumento,                  IdtipoDocumento,                     IdNroHistoriaClinica,              IdTipoNroHistoriaClinica,             IdFechaRegistro, IdEstado)" + 
                                                 " VALUES('" + txtPaterno.Text + "','" + txtMaterno.Text + "','" + txtPrimerNombre.Text + "','" + txtSegundoNombre.Text + "','" + dtpFechaNacimiento.Value.Date + "','" + txtNroDocumento.Text + "'," + cmbTipoDocumento.SelectedValue +"," + txtNroHistoriaClinica.Text + "," + cmbHistoriaClinica.SelectedValue + ", getdate(),       '1'        )";

                FrmPrincipal.Cn.Open();
                command.ExecuteNonQuery();
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
                MessageBox.Show("Digite nombre de Alumno.");
            }



            //
        }
    }
}
