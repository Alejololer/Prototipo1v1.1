using DataAccess.Entities;
using Domain;
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
    public partial class ModificarPrecio : Form
    {
        TipoExamen tipoExamen = null;
        public ModificarPrecio()
        {
            InitializeComponent();
            txtValor.ReadOnly = true;
            txtNomTipo.KeyPress += OnKeyPress;
            txtNuevoValor.KeyPress += OnKeyPressNum;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(tipoExamen == null)
            {
                MessageBox.Show("Primero consulte un Tipo de Examen!", "Modificar precio Tipo de Examen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(!EsPrecioValido(txtNuevoValor.Text)) {
                MessageBox.Show("Nuevo costo de Tipo de examen inválido!", "Modificar precio Tipo de Examen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult result = MessageBox.Show("¿Está seguro?", "Modificar precio Tipo de Examen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                TipoExamenModel model = new TipoExamenModel();
                model.ActualizarPrecioTipoExamen(txtNomTipo.Text, decimal.Parse(txtNuevoValor.Text));
                MessageBox.Show("Costo de Tipo de Examen modificado correctamente", "Modificar precio Tipo de Examen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNuevoValor.Text = "";
                obtenerPrecio();
            }
            else
            {

            };
        }

        private void ModificarPrecio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            obtenerPrecio();
            
        }

        private void OnKeyPress(object? sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar switch
            {
                >= '0' and <= '9' => false, // allow numerics
                >= 'a' and <= 'z' => false, // allow lowercase characters
                >= 'A' and <= 'Z' => false, // allow uppercase characters
                '\b' => false,              // allow backspace
                '-' => false,
                '/' => false,
                _ => true
            };

        }

        private void OnKeyPressNum(object? sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar switch
            {
                >= '0' and <= '9' => false, // allow numerics
                '\b' => false,              // allow backspace
                '.' => false,
                _ => true
            };

        }

        private bool EsPrecioValido(string texto)
        {
            // Verificar si el texto está vacío
            if (string.IsNullOrWhiteSpace(texto))
                return false;

            // Verificar si el texto contiene solo dígitos y un solo punto
            bool puntoEncontrado = false;
            foreach (char caracter in texto)
            {
                if (caracter == '.')
                {
                    // Permitir solo un punto en la cadena
                    if (puntoEncontrado)
                        return false;
                    puntoEncontrado = true;
                }
                else if (!char.IsDigit(caracter))
                {
                    // Permitir solo dígitos y un punto en la cadena
                    return false;
                }
            }

            // Verificar si el texto representa un número válido
            return decimal.TryParse(texto, out _);
        }

        private void obtenerPrecio()
        {
            if(txtNomTipo.Text.Length <= 1)
            {
                MessageBox.Show("Nombre de Tipo de examen inválido!", "Modificar precio Tipo de Examen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            TipoExamenModel model = new TipoExamenModel();
            if (!model.Check(txtNomTipo.Text))
            {
                MessageBox.Show("Tipo de examen no encontrado!", "Modificar precio Tipo de Examen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            tipoExamen = model.GetTipoExamen(txtNomTipo.Text);
            txtValor.Text = tipoExamen.costoTipoExamen.ToString("#.##");
        }
    }
}
