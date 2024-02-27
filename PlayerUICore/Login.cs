using PlayerUI.ConeccionBD;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace PlayerUI
{
    public partial class Login : Form
    {

        // Conexión a la base de datos
        private const string connectionString = "Data Source=TONY;Initial Catalog=Laboratorio;Integrated Security=True;Encrypt=False"; // Reemplaza con tu cadena de conexión

        public Login()
        {
            InitializeComponent();
            txtContrasena.KeyPress += OnKeyPress;
            txtUsuario.KeyPress += OnKeyPress;

        }


        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {

                if (txtContrasena.Text != "")
                {

                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtUsuario.Text, txtContrasena.Text);
                    if (validLogin == true)
                    {
                        this.Hide();

                        // Crear una instancia del nuevo formulario que quieres mostrar
                        Menu nuevoFormulario = new Menu();

                        // Suscribir al evento FormClosed del nuevo formulario
                        nuevoFormulario.FormClosed += NuevoFormulario_FormClosed;

                        txtContrasena.Text = "";
                        txtUsuario.Text = "";

                        // Mostrar el nuevo formulario
                        nuevoFormulario.Show();
                    }
                    else
                    {
                        msgError("Nombre de usuario o contraseña incorrectos. Intente de nuevo");
                        txtContrasena.Clear();
                        txtUsuario.Clear();
                    }

                }
                else msgError("Ingrese la contraseña");

            }
            else msgError("Ingrese el nombre de usuario");

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        // Método para manejar el evento FormClosed del nuevo formulario
        private void NuevoFormulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Mostrar nuevamente el formulario original una vez que se cierre el segundo formulario
            this.Show();
        }

        private void msgError(string msg)
        {
            lblError.Text = msg;
            lblError.Visible = true;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
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
                _ => true
            };

        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
