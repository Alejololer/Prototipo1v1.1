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

    }
}
