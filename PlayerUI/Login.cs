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

namespace PlayerUI
{
    public partial class Login : Form
    {

        // Conexión a la base de datos
        private const string connectionString = "Data Source=TONY;Initial Catalog=Laboratorio;Integrated Security=True;Encrypt=False"; // Reemplaza con tu cadena de conexión

        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            // Validar usuario y contraseña
            if (ValidarUsuario(usuario, contrasena))
            {
                MessageBox.Show("Inicio de sesión exitoso");
                // Puedes redirigir a otra ventana o realizar otras acciones después de un inicio de sesión exitoso
            }
            else
            {
                MessageBox.Show("Error: Usuario o contraseña incorrectos");
            }
        }

        private bool ValidarUsuario(string usuario, string contrasena)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta SQL para validar el usuario y contraseña
                    string query = "SELECT COUNT(*) FROM Usuario WHERE userName = @Usuario AND password = @Contrasena";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parámetros para evitar la inyección SQL
                        command.Parameters.AddWithValue("@Usuario", usuario);
                        command.Parameters.AddWithValue("@Contrasena", contrasena);

                        int count = (int)command.ExecuteScalar();

                        // Si count es mayor a 0, el usuario y la contraseña son válidos
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexión a la base de datos: " + ex.Message);
                    return false;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario actual
            this.Hide();

            // Crear una instancia del nuevo formulario que quieres mostrar
            Menu nuevoFormulario = new Menu();

            // Suscribir al evento FormClosed del nuevo formulario
            nuevoFormulario.FormClosed += NuevoFormulario_FormClosed;

            // Mostrar el nuevo formulario
            nuevoFormulario.Show();
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
    }
}
