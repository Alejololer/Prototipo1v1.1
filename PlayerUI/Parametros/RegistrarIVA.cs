using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI.Parametros
{
    public partial class RegistrarIVA : Form
    {
        public RegistrarIVA()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Enviar un mensaje
            DialogResult result = MessageBox.Show("¿Está seguro?", "Registrar IVA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("IVA registrado correctamente", "Registrar IVA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            };
        }
    }
}
