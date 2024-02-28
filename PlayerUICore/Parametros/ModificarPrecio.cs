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
        public ModificarPrecio()
        {
            InitializeComponent();
            txtValor.ReadOnly = true;
            txtNomTipo.KeyPress += OnKeyPress;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Enviar un mensaje
            DialogResult result = MessageBox.Show("¿Está seguro?", "Modificar precio Tipo de Examen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                MessageBox.Show("Precio de Tipo de Examen modificado correctamente", "Modificar precio Tipo de Examen", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            TipoExamenModel model = new TipoExamenModel();
            if(txtNomTipo.Text.Length <= 1)
            {
                MessageBox.Show("Nombre de Tipo de examen inválido!", "Modificar precio Tipo de Examen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!model.Check(txtNomTipo.Text))
            {
                MessageBox.Show("Tipo de examen no encontrado!", "Modificar precio Tipo de Examen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            TipoExamen tipoExamen = model.GetTipoExamen(txtNomTipo.Text);
            txtValor.Text = tipoExamen.costoTipoExamen.ToString();
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
    }
}
