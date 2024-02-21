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
    public partial class DardealtaPaciente : Form
    {
        public DardealtaPaciente()
        {
            InitializeComponent();
        }

        private void lblInstrumento_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizarInstrumento_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Se ha dado de Alta exitosamente!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
