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
    public partial class RegistrarTipoExamen : Form
    {
        TipoExamen tipoExamen = null;
        public RegistrarTipoExamen()
        {
            InitializeComponent();
            txtNomTipo.KeyPress += OnKeyPress;
            txtCostoTipo.KeyPress += OnKeyPressNum;
            txtNomPar.KeyPress += OnKeyPress;
            txtvalMax.KeyPress += OnKeyPressNum;
            txtValMin.KeyPress += OnKeyPressNum;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string NombreTipo = txtNomPar.Text;
            if (txtNomTipo.Text.Length <= 1)
            {
                MessageBox.Show("Nombre de Tipo de examen inválido!", "Registrar Tipo de Examen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtCostoTipo.Text=="" || !EsPrecioValido(txtCostoTipo.Text))
            {
                MessageBox.Show("Costo de Tipo de examen inválido!", "Registrar Tipo de Examen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult result = MessageBox.Show("¿Está seguro?", "Registro de Paciente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                TipoExamenModel model = new TipoExamenModel();
                if (model.Check(txtNomTipo.Text))
                {
                    MessageBox.Show("Tipo de Examen ya registrado!", "Registrar Tipo de Examen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                model.RegistrarTipoExamen(txtNomTipo.Text, decimal.Parse(txtCostoTipo.Text));
                tipoExamen = model.GetTipoExamen(txtNomTipo.Text);
                MessageBox.Show("Tipo de Examen registrado correctamente", "Registrar Tipo de Examen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrarTipoExamen_Load(object sender, EventArgs e)
        {

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

        private bool EsNumeroDecimalValido(string texto)
        {
            // Verificar si el texto está vacío
            if (texto == "")
                return true;

            // Verificar si el texto representa un número decimal válido
            return decimal.TryParse(texto, out _);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tipoExamen ==null)
            {
                MessageBox.Show("Primero registra el tipo de examen!", "Registrar Parámetro de Tipo de Examen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!EsNumeroDecimalValido(txtValMin.Text))
            {
                MessageBox.Show("Valor mínimo no válido!", "Registrar Parámetro de Tipo de Examen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!EsNumeroDecimalValido(txtvalMax.Text))
            {
                MessageBox.Show("Valor máximo no válido!", "Registrar Parámetro de Tipo de Examen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtvalMax.Text == "" && txtValMin.Text != "")
            {
                MessageBox.Show("Si registra un valor mínimo, registre un valor máximo!", "Registrar Parámetro de Tipo de Examen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtvalMax.Text != "" && txtValMin.Text == "")
            {
                MessageBox.Show("Si registra un valor máximo, registre un valor mínimo!", "Registrar Parámetro de Tipo de Examen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtvalMax.Text != "")
            {
                if (float.Parse(txtvalMax.Text) <= float.Parse(txtValMin.Text))
                {
                    MessageBox.Show("El valor máximo debe ser mayor al valor mínimo!", "Registrar Parámetro de Tipo de Examen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (txtNomPar.Text == "")
            {
                MessageBox.Show("Nombre de parámetro inválido!", "Registrar Parámetro de Tipo de Examen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtNomPar.Text == "")
            {
                MessageBox.Show("Nombre de parámetro inválido!", "Registrar Parámetro de Tipo de Examen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult result = MessageBox.Show("¿Está seguro?", "Registrar Parámetro de Tipo de Examen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ParametroTipoExamenModel parametroTipoExamenModel = new ParametroTipoExamenModel();
                if (txtvalMax.Text != "" && txtValMin.Text != "" && txtUn.Text != "")
                    parametroTipoExamenModel.registrarParTipoExamen(tipoExamen.Id, txtNomPar.Text, float.Parse(txtValMin.Text), float.Parse(txtvalMax.Text), txtUn.Text.Trim());
                else if (txtvalMax.Text != "" && txtValMin.Text != "")
                    parametroTipoExamenModel.registrarParTipoExamenRango(tipoExamen.Id, txtNomPar.Text, float.Parse(txtValMin.Text), float.Parse(txtvalMax.Text));
                else if (txtUn.Text != "")
                    parametroTipoExamenModel.registrarParTipoExamenUnidad(tipoExamen.Id, txtNomPar.Text, txtUn.Text.Trim());
                else
                    parametroTipoExamenModel.registrarParTipoExamenNull(tipoExamen.Id, txtNomPar.Text);
                MessageBox.Show("Parámetro registrado correctamente!", "Registrar Parámetro de Tipo de Examen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomPar.Text = "";
                txtvalMax.Text = "";
                txtValMin.Text = "";
                txtUn.Text = "";
            }
        }
    }
}
