using System;
using System.Xml.Serialization;

namespace DentistAdmin
{
    [Serializable]
    public abstract class Human
    {
        public readonly string Name;
        public readonly string Surname;
        public readonly string Patronymic;
        public string FullName
        {
            get
            {
                return $"{Surname} {Name} {Patronymic}";
            }
        }

        public Human(string name, string surname, string pathronymic)
        {
            Name = name;
            Surname = surname;
            Patronymic = pathronymic;
        }

        public Human() { }
    }
}
