using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class VentaDAO : ConnectionToSQL
    {
        public bool registrarVenta(string cedula, int idpedido)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Insert into Pacientes(CIPACIENTE, NOMBRESPACIENTE, APELLIDOSPACIENTE, TELEFONOPACIENTE, CORREOPACIENTE, DIRECCIONPACIENTE, FECHANACPACIENTE) values (@cedula, @nombres, @apellidos, @telefono, @correo, @direccion, @fechanac)";
                    command.Parameters.AddWithValue("@cedula", cedula);
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
