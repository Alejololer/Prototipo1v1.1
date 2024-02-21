using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI.Instrumento
{
    public partial class ActualizarInstrumento : Form
    {
        string nombreInstrumento;
        string cantidadEntrada;
        string cantidadSalida;

        public ActualizarInstrumento()
        {
            InitializeComponent();
        }

        private void btnActualizarInstrumento_Click(object sender, EventArgs e)
        {
            nombreInstrumento = txtNombreInstrumento.Text;
            cantidadEntrada = txtCantidadEntrada.Text;
            cantidadSalida = txtCantidadSalida.Text;

            MessageBox.Show("Cantidad de instrumento actualizada correctamente");
            MessageBox.Show("Nombre de instrumento inválido");
            MessageBox.Show("Cantidades de entrada y/o salida inválidas");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
