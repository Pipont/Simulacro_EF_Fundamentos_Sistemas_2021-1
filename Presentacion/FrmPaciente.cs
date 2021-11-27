using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocio;
using Entidades;


namespace Presentacion
{
    public partial class FrmPaciente : Form
    {

        nPaciente gestor_paciente = new nPaciente();
        public FrmPaciente()
        {
            InitializeComponent();
            dataGridView1.DataSource = gestor_paciente.ListarPacientes();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(txtDNI.Text!=""&&txtFechaN.Text!=""&&txtFechaR.Text!=""&&txtNombre.Text!=""&&cboxDistrito.SelectedIndex != -1 && cboxSexo.SelectedIndex != -1)
            {
                if (txtDNI.Text.Length == 8)
                {
                    if (!gestor_paciente.ExistePaciente(txtDNI.Text))
                    {
                        MessageBox.Show(gestor_paciente.RegistrarPaciente(txtDNI.Text, txtNombre.Text, cboxSexo.Text, cboxDistrito.Text, Convert.ToInt32(txtFechaN.Text), Convert.ToInt32(txtFechaR.Text)));
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = gestor_paciente.ListarPacientes();
                    }
                    else { MessageBox.Show("PACIENTE YA EXISTE"); }


                }
                else { MessageBox.Show("DNI DEBE SER DE 8 DÍGITOS"); }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text != "")
            {
                MessageBox.Show(gestor_paciente.EliminarPaciente(txtDNI.Text));
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = gestor_paciente.ListarPacientes();
            }
            else { MessageBox.Show("FALTA DNI PS"); }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text != "" && txtFechaN.Text != "" && txtFechaR.Text != "" && txtNombre.Text != "" && cboxDistrito.SelectedIndex != -1 && cboxSexo.SelectedIndex != -1)
            {
                if (txtDNI.Text.Length == 8)
                {
                    if (gestor_paciente.ExistePaciente(txtDNI.Text))
                    {
                        MessageBox.Show(gestor_paciente.ModificarPaciente(txtNombre.Text, cboxSexo.Text, cboxDistrito.Text, Convert.ToInt32(txtFechaN.Text), Convert.ToInt32(txtFechaR.Text), txtDNI.Text));
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = gestor_paciente.ListarPacientes();
                    }
                    else { MessageBox.Show("PACIENTE NO EXISTE"); }
                }
                else { MessageBox.Show("DNI NO TIENE 8 DÍGITOS"); }
            }
        }

        private void btnMayorTiempo_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = gestor_paciente.ListarMayorTiempoRegistrados();
        }

        private void btnCantV_Click(object sender, EventArgs e)
        {
            MessageBox.Show(gestor_paciente.DistritoMenorNroVaros());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCantidad form = new FrmCantidad();
            form.Show();
        }
    }
}
