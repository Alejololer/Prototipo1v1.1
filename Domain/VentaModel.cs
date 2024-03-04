using DataAccess;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class VentaModel
    {
        VentaDAO ventaDAO = new VentaDAO();
        public bool Check(int IdPedido)
        {
            return ventaDAO.Check(IdPedido);
        }
        public Venta consultarDatosVenta(string cedula, int idpedido, int IVA)
        {
            return ventaDAO.consultarDatosVenta(cedula, idpedido, IVA);
        }

        public void registrarVenta(Venta venta)
        {
            ventaDAO.registrarVenta(venta);
        }

    }
}
