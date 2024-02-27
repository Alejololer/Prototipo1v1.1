using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public class UserDAO : ConnectionToSQL
    {
        public bool Login(string username, string password)
        {
            using(var connection = GetConnection())
            {
                connection.Open ();
                using (var command = new SqlCommand ()) {
                    command.Connection = connection;
                    command.CommandText = "Select * from Users where nombreUser=@user and claveUser=@password";
                    command.Parameters.AddWithValue ("@user", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.CommandType = System.Data.CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader ();
                    if(reader.HasRows)
                    {
                        return true;
                    }else
                        return false;
                }
            }
        }
        public bool checkUsuario(string username)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select * from Users where NOMBREUSER=@user";
                    command.Parameters.AddWithValue("@user", username);
                    command.CommandType = System.Data.CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        public bool RegistrarUsuario(string nombreusuario, string contrasena, string tipousuario)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Insert into USERS(NOMBREUSER, CLAVEUSER, TIPOUSER) VALUES (@nombreuser, @claveuser, @tipouser)";
                    command.Parameters.AddWithValue("@nombreuser", nombreusuario);
                    command.Parameters.AddWithValue("@claveuser", contrasena);
                    command.Parameters.AddWithValue("@tipouser", tipousuario);
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

        public bool EliminarUsuario(string nombreusuario)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM USERS WHERE NOMBREUSER = @nombreuser";
                    command.Parameters.AddWithValue("@nombreuser", nombreusuario);
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
