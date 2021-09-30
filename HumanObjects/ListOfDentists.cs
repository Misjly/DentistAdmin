using DentistAdmin.ServiceObjects;
using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DentistAdmin.HumanObjects
{
    [Serializable]
    public class ListOfDentists
    {
        private readonly string _fileName;
        private BindingList<Dentist> _dentists { get; set; } = new BindingList<Dentist>();

        public ListOfDentists() { }
        public ListOfDentists(string fileName)
        {
            _fileName = fileName;
            if(File.Exists(fileName))
            {
                var binaryFormatter = new BinaryFormatter();

                using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
                {
                    if (fs.Length > 0)
                        _dentists = (binaryFormatter.Deserialize(fs) as ListOfDentists)._dentists;
                }
            }
        }

        public void Save()
        {
            if (File.Exists(_fileName))
                File.Delete(_fileName);

            var binaryFormatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(_fileName, FileMode.Create))
            {
                binaryFormatter.Serialize(fs, this);
                fs.Close();
            }
        }

        public BindingList<Dentist> GetDentists()
        {
            return _dentists;
        }

        public void AddDentist(string name, string surname, string patronymic, string specialization, Schedule schedule)
        {
            var dentist = new Dentist(name, surname, patronymic, specialization, schedule);
            if (_dentists.IndexOf(dentist) == -1)
            {
                _dentists.Add(new Dentist(name, surname, patronymic, specialization, schedule));
            }
            Save();
        }

        public void DeleteDentist(Dentist dentist)
        {
            if (_dentists.IndexOf(dentist) != -1)
            {
                _dentists.Remove(dentist);
            }

            var formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(_fileName, FileMode.Open))
            {
                formatter.Serialize(fs, _dentists);
            }
        }
    }
}
