
using DataAccess;

namespace Domain
{
    public class UserModel
    {
        UserDAO userDAO = new UserDAO();
        public bool LoginUser(string username, string password)
        {
            return userDAO.Login(username, password);
        }

        public bool RegistrarUsuario(string nombreusuario, string contrasena, string tipousuario)
        {
            return userDAO.RegistrarUsuario(nombreusuario, contrasena, tipousuario);
        }

        public bool CheckUsuario(string username)
        {
            return userDAO.checkUsuario(username);
        }

        public bool EliminarUsuario(string username)
        {
            return userDAO.EliminarUsuario(username);
        }
    }

    
}
