using DentistAdmin.ServiceObjects;
using System;

namespace DentistAdmin
{

    [Serializable]
    public class Client : Human
    {
        public Service Procedure{ get; set; }
        public DateTime StartOfProcedure { get; set; }
        public DateTime EndOfProcedure { get; set; }
        public string FullInfo
        {
            get
            {
                return $"{StartOfProcedure.Day}.{StartOfProcedure.Month}.{StartOfProcedure.Year}" +
                    $"\t|{StartOfProcedure.Hour}:{StartOfProcedure.Minute} - {EndOfProcedure.Hour}:{EndOfProcedure.Minute}|" +
                    $"\t{Surname} {Name} {Patronymic}" +
                    $"\t{Procedure.Name}" +
                    $"\t{Procedure.Price} BYR";
            }
        }

        public Client(Service service, string name, string surname, string patronymic, DateTime date, DateTime endOfProcedure)
            :base(name, surname, patronymic)
        {
            Procedure = new Service(service.Name, service.Price);
            StartOfProcedure = date;
            EndOfProcedure = endOfProcedure;
        }
    }
}
