using DentistAdmin.ServiceObjects;
using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DentistAdmin.HumanObjects
{
    [Serializable]
    public class ListOfClients
    {
        private BindingList<Client> _clients { get; set; } = new BindingList<Client>();

        public void AddClient(Service service, string name, string surname, string pathronymic, DateTime date, DateTime endOfProcedure)
        {
            Client client = new Client(service, name, surname, pathronymic, date, endOfProcedure);
            if (_clients.IndexOf(client) == -1)
            {
                _clients.Add(client);
            }
        }

        public void AddClient(Client client)
        {
            _clients.Add(client);
        }

        public void DeleteClient(Client client)
        {
            if (_clients.IndexOf(client) != -1)
            {
                _clients.Remove(client);
            }
        }

        public BindingList<Client> GetClients()
        {
            return _clients;
        }


    }
}
