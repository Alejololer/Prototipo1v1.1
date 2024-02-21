using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI.Pedidos
{
    public partial class EliminarPedido : Form
    {
        public EliminarPedido()
        {
            InitializeComponent();
        }

        private void btnActualizarInstrumento_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Eliminación del pedido realizado exitosamente!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
