
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

    }
}
