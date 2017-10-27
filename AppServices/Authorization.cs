using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppData;

namespace AppServices
{
    public class Authorization
    {
        public User currentUser = new User();
        DataBase dataBase = new DataBase();

        public User AuthorityVerify(string login, string password)
        {
            foreach (var user in dataBase.GetUsers())
            {
                if (user.Login == login && user.Password == password)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
