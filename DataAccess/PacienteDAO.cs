using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class PacienteDAO : ConnectionToSQL
    {
        public void registrarPaciente(int cedula, string nombres, string apellidos, string telefono, string direccion,
            string correo, DateOnly fechanac)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Insert into Pacientes(CIPACIENTE, NOMBRESPACIENTE, APELLIDOSPACIENTE, TELEFONOPACIENTE" +
                                            "CORREOPACIENTE, DIRECCIONPACIENTE) values (@cedula, @nombres, @apellidos, @telefono" +
                                            ", @direccion, @correo, @fechanac";
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@nombres", nombres);
                    command.Parameters.AddWithValue("@apellidos", apellidos);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@fechanac", fechanac);
                }
            }
        }
    }
}
