using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using AppModels;

namespace AppData
{
    public class DataBase
    {
        private List<Client> clients;
        FireBaseService firebaseService;

        public DataBase()
        {
            firebaseService = new FireBaseService();
            firebaseService.SunchronizeUsers();
            clients = firebaseService.GetClients();
        }
        public void Add(Client client)
        {
            firebaseService.AddClient(client);
            this.clients.Add(client);
        }

        public Client GetClient(long pin)
        {
            foreach (var client in clients)
            {
                if (client.Pin == pin)
                {
                    return client;
                }
            }
            return null;
        }
        public List<Client> GetClients()
        {
            return clients;
        }
    }
}
