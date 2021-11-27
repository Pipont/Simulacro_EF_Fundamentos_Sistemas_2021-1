using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class FrmCantidad : Form
    {
        nPaciente gestor_paciente = new nPaciente();
        public FrmCantidad()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(gestor_paciente.CantidadNiñosJovenes(cboxDistrito.Text));

        }
    }
}
