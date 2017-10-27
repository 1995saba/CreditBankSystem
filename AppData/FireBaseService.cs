using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppModels;
using Firebase.Database;
using Firebase.Database.Query;

namespace AppData
{
    public class FireBaseService
    {
        private FirebaseClient firebaseClient;
        private const string databaseURL = "https://creditbanksystem-fbde2.firebaseio.com/";
        private List<FirebaseObject<Client>> firebaseObjectClientList;
        private List<Client> clients;

        public FireBaseService()
        {
            clients = new List<Client>();
            firebaseClient = new FirebaseClient(databaseURL);
            firebaseObjectClientList = new List<FirebaseObject<Client>>();
        }

        public async void AddClient(Client client)
        {
            firebaseObjectClientList.Add(await firebaseClient.Child("Clients").PostAsync(client, true));
            clients.Add(client);
        }

        public async void SunchronizeUsers()
        {
            var clients = await firebaseClient.Child("Clients").OnceAsync<Client>();
            foreach (var oneClient in clients)
            {
                firebaseObjectClientList.Add(oneClient);
            }
            foreach (FirebaseObject<Client> client in firebaseObjectClientList)
            {
                this.clients.Add(client.Object);
            }
        }

        public List<Client> GetClients()
        {
            return clients;
        }
    }
}
