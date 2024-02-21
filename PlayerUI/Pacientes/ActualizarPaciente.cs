using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI.Pacientes
{
    public partial class ActualizarPaciente : Form
    {
        public ActualizarPaciente()
        {
            InitializeComponent();
        }

        private void btnActualizarInstrumento_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Se ha actualizado correctamente!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
