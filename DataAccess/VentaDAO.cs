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
        public Venta consultarDatosVenta(string cedula, int idpedido, int IVA)
        {
            Venta venta = null;
            using (var connection = GetConnection())
            {
                connection.Open();
                decimal totalNoIva = 0;
                decimal totalIva = 0;
                decimal ivaPedido = 0;
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT SUM(COSTOTIPOEXAMEN) FROM EXAMENES JOIN TIPOSEXAMEN" +
                        " ON EXAMENES.IDTIPOEXAMEN = TIPOSEXAMEN.IDTIPOEXAMEN WHERE EXAMENES.IDPEDIDO = @idPedido";
                    command.Parameters.AddWithValue("@idPedido", idpedido);
                    object result = command.ExecuteScalar();

                    // Verifica si el resultado no es nulo y es convertible a decimal
                    if (result != null && result != DBNull.Value)
                    {
                        // Convierte el resultado a decimal
                        totalNoIva = Convert.ToDecimal(result);
                    }
                }
                ivaPedido = totalNoIva * IVA / 100;
                totalIva = totalNoIva + ivaPedido;
                venta = new Venta(idpedido, cedula, totalNoIva, totalIva, ivaPedido);
                
            }
            return venta;
        }

        public bool Check(int idPedido)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM VENTAS WHERE IDPEDIDO=@idPedido AND ESTADOVENTA = 'NO'";
                    command.Parameters.AddWithValue("@idPedido", idPedido);
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

        public void registrarVenta(Venta venta)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO VENTAS(IDPEDIDO, CIPACIENTE, PRECIOTOTALVENTA, PRECIOFINALVENTA) VALUES (@idPedido, @ciPaciente, @precioVenta, @precioVenta)";
                    command.Parameters.AddWithValue("@idPedido", venta.idPedido);
                    command.Parameters.AddWithValue("@ciPaciente", venta.CIPaciente);
                    command.Parameters.AddWithValue("@precioVenta", venta.precioFinalIVA);
                    command.ExecuteReader();
                }
            }
        }
    }
}
