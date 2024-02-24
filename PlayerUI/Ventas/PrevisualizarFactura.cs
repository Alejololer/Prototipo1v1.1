﻿using System;
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
            // Enviar un mensaje
            DialogResult result = MessageBox.Show("¿Está seguro?", "Generar Prefactura", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Prefactura generada correctamente", "Generar Prefactura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            };
        }
    }
}
