using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using AppModels;
using AppServices;

namespace AppData
{
    public class Database
    {
        public long Id { get; set; }
        private List<Client> clients;
        FirebaseService firebaseService;
        public Database()
        {
            firebaseService = new FirebaseService();
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
