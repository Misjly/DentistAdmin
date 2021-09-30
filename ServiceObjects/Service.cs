using System;

namespace DentistAdmin.ServiceObjects
{
    [Serializable]
    public class Service
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{Name} за {Price} BYR";
            }
        }
        public Service(string name, double price)
        {
            Name = name;
            Price = price;
        }
}
}
