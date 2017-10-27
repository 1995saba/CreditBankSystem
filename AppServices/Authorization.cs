using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppModels;
using AppData;

namespace AppServices
{
    public class Authorization
    {
        public Client currentClient = new Client();
        DataBase dataBase = new DataBase();

        public Client AuthorityVerify(string pin, string password)
        {
            foreach (var client in dataBase.GetClients())
            {
                if (client.Pin.ToString() == pin && client.Password == password)
                {
                    return client;
                }
            }
            return null;
        }
    }
}
