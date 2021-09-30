using DentistAdmin.HumanObjects;
using DentistAdmin.ServiceObjects;
using System;
using System.Linq;

namespace DentistAdmin
{
    [Serializable]
    public class Dentist : Human
    {
        public readonly string Specialization;
        public string FullInfo
        {
            get
            {
                return $"{FullName} {Specialization.ToString()}";
            }
        }

        private ListOfClients ClientsList { get; set; } = new ListOfClients();
        public readonly Schedule Timetable;

        public Dentist() { }
        public Dentist(string name, string surname, string patronymic, string specialization, Schedule timetable)
            :base(name, surname, patronymic)
        {
            Specialization = specialization;
            Timetable = timetable;
        }

        public ListOfClients GetListOfClients()
        {
            return ClientsList;
        }

        public void AddClient(Client client)
        {
            ClientsList.AddClient(client);
        }

        public void DeleteClient(Client client)
        {
            ClientsList.DeleteClient(client);
        }
    }
}
