using DataAccess;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class TipoExamenModel
    {
        TipoExamenDOA tipoExamenDOA = new TipoExamenDOA();
        public bool Check(string nombre)
        {
            return tipoExamenDOA.Check(nombre);
        }

        public TipoExamen GetTipoExamen(string nombre)
        {
            return tipoExamenDOA.GetTipoExamen(nombre);
        }

        public bool RegistrarTipoExamen(string nombre, decimal costo)
        {
            return tipoExamenDOA.RegistrarTipoExamen(nombre, costo);
        }
    }
}
