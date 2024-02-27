using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PlayerUI.Usuario
{
    public partial class ConsultarUsuario : Form
    {
        string nombreUsuario;
        SqlConnection coneccion = new SqlConnection("Data Source=TONY;Initial Catalog=Requerimientos;Integrated Security=SSPI");

        public ConsultarUsuario()
        {
            InitializeComponent();
        }
        private void ConsultarUsuario_Load(object sender, EventArgs e)
        {
            llenarDataGridView();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                // Obtener el nombre del usuario seleccionado (ajusta esto según tu estructura de datos)
                string nombreUsuario = dgvUsuarios.SelectedRows[0].Cells["NombreUsuario"].Value.ToString();

                // Mostrar mensaje de confirmación
                DialogResult result = MessageBox.Show($"¿Está seguro de que desea eliminar al usuario '{nombreUsuario}'?", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar la respuesta del usuario
                if (result == DialogResult.Yes)
                {
                    EliminarUsuario();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila antes de intentar eliminar un usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void EliminarUsuario()
        {
            try
            {
                using (var connection = coneccion)
                {
                    connection.Open();

                    using (var consulta = new SqlCommand("DELETE FROM PACIENTES WHERE NOMBREUSER = @Nombre", connection))
                    {
                        consulta.Parameters.AddWithValue("@Nombre", nombreUsuario);

                        int filasAfectadas = consulta.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Usuario eliminado exitosamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            consultarUsuarios(); // Método para actualizar la lista de usuarios en el DataGridView
                        }
                        else
                        {
                            MessageBox.Show("No se pudo encontrar el usuario para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar eliminar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void consultarUsuarios()
        {
            using (var connection = coneccion)
            using (var consulta = new SqlCommand("SELECT * FROM Users WHERE NOMBREUSER = @user", connection))
            {
                connection.Open();

                consulta.Parameters.AddWithValue("@user", nombreUsuario);

                using (SqlDataAdapter adapter = new SqlDataAdapter(consulta))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvUsuarios.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron usuarios con ese nombre.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            nombreUsuario = txtNombreUsuario.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombreUsuario))
            {
                MessageBox.Show("Por favor, ingrese un nombre de usuario.", "Verificar datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidarSoloTexto(nombreUsuario))
            {
                MessageBox.Show("El nombre de usuario no es válido (debe contener solo letras).", "Verificar datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            consultarUsuarios();
        }

        private void llenarDataGridView()
        {
            try
            {
                string consulta = "SELECT * FROM dbo.USERS";

                using (var connection = coneccion)
                using (SqlDataAdapter adapter = new SqlDataAdapter(consulta, connection))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvUsuarios.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al llenar el DataGridView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool ValidarSoloTexto(string texto)
        {
            // Verificar si el texto contiene solo letras
            return texto.All(char.IsLetter);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
