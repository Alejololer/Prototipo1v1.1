﻿using System;
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
    public partial class ActualizarPedido : Form
    {
        public ActualizarPedido()
        {
            InitializeComponent();
        }

        private void ActualizarPedido_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Se añadió correctamente!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Registro exitoso!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Se eliminó correctamente el pedido!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}