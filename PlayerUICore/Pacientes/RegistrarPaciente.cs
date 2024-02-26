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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PlayerUI.Pacientes
{
    public partial class RegistrarPaciente : Form
    {
        public RegistrarPaciente()
        {
            InitializeComponent();
            txtCed.KeyPress += OnKeyPressNum;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bool formatoValido = ValidarFormatoNombre(txtCed); // Reemplaza textBox1 con el nombre de tu TextBox
            if (formatoValido)
            {
                // Realizar acciones si el formato es válido
                MessageBox.Show("El formato del nombre es válido.", "Formato válido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Realizar acciones si el formato no es válido
                MessageBox.Show("El formato del nombre no es válido.", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            DialogResult result = MessageBox.Show("¿Está seguro?", "Registro de Paciente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                PacienteModel model = new PacienteModel();
                //var valid 
                //MessageBox.Show("Paciente registrado con éxito", "Registro de Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
            }
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void OnKeyPressNum(object? sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar switch
            {
                >= '0' and <= '9' => false, // allow numerics
                '\b' => false,              // allow backspace

            };
        }


        private bool ValidarFormatoNombre(System.Windows.Forms.TextBox textBox)
        {
            // Verificar si el texto está en el formato "Nombre Apellido"
            string[] partes = textBox.Text.Split(' ');
            if (partes.Length != 2)
            {
                MessageBox.Show("El formato debe ser 'Nombre Apellido'.", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                bool formatoCorrecto = partes.All(part => !string.IsNullOrWhiteSpace(part) && part.All(char.IsLetter));
                if (!formatoCorrecto)
                {
                    MessageBox.Show("El formato debe ser 'Nombre Apellido'.", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }


    }
}
