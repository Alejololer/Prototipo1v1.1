using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class PacienteDAO : ConnectionToSQL
    {
        public bool registrarPaciente(string cedula, string nombres, string apellidos, string telefono, string direccion,
            string correo, string fechanac)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Insert into Pacientes(CIPACIENTE, NOMBRESPACIENTE, APELLIDOSPACIENTE, TELEFONOPACIENTE, CORREOPACIENTE, DIRECCIONPACIENTE, FECHANACPACIENTE) values (@cedula, @nombres, @apellidos, @telefono, @direccion, @correo, @fechanac)";
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@nombres", nombres);
                    command.Parameters.AddWithValue("@apellidos", apellidos);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@correo", correo);
                    command.Parameters.AddWithValue("@fechanac", fechanac);
                    int filasAfectadas = command.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
