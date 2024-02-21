using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI.Ventas
{
    public partial class PrevisualizarFactura : Form
    {
        string pedido;

        public PrevisualizarFactura()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultarInstrumento_Click(object sender, EventArgs e)
        {
            pedido = cmbxPedidos.Text;
            MessageBox.Show("Error en la previsualización de la factura");
        }
    }
}
