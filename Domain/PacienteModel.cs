using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Domain
{
    public class PacienteModel
    {
        PacienteDAO pacienteDAO = new PacienteDAO();

        public  bool registrarPaciente(string cedula, string nombres, string apellidos, string telefono, string direccion,
            string correo, string fechanac)
        {
            return pacienteDAO.registrarPaciente(cedula, nombres, apellidos, telefono, direccion
                , correo, fechanac);
        }

        public bool Check(string cedula)
        {
            return pacienteDAO.Check(cedula);
        }
    }
}
