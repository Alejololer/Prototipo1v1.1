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
    public partial class EliminarInstrumento : Form
    {
        string nombreInstrumento;
        string cantidadEntrada;
        string cantidadSalida;

        public EliminarInstrumento()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizarInstrumento_Click(object sender, EventArgs e)
        {
            nombreInstrumento = txtNombreInstrumento.Text;
            cantidadEntrada = txtCantidadEntrada.Text;
            cantidadSalida = txtCantidadSalida.Text;

            MessageBox.Show("Instrumento eliminado correctamente");
            MessageBox.Show("Nombre de instrumento inválido");
            MessageBox.Show("Cantidades de entrada y/o salida inválidas");
        }
    }
}
