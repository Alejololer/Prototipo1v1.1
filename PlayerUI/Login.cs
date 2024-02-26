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
using Domain.UsermModel;


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
                    this.Hide();

                    // Crear una instancia del nuevo formulario que quieres mostrar
                    Menu nuevoFormulario = new Menu();

                    // Suscribir al evento FormClosed del nuevo formulario
                    nuevoFormulario.FormClosed += NuevoFormulario_FormClosed;

                    // Mostrar el nuevo formulario
                    nuevoFormulario.Show();
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
    }
}
