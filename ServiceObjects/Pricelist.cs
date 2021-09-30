using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DentistAdmin.ServiceObjects
{
    [Serializable]
    public class Pricelist
    {
        private readonly string _fileName;
        private BindingList<Service> Services { get; set; } = new BindingList<Service>();

        public Pricelist(string fileName)
        {
            _fileName = fileName;
            var formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                if (fs.Length > 0)
                {
                    var tempPricelist = formatter.Deserialize(fs) as Pricelist;
                        Services = tempPricelist.Services;
                }
            }
        }

        public BindingList<Service> GetPricelist()
        {
            return Services;
        }

        public void Add(Service service)
        {
            Services.Add(service);

            var formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(_fileName, FileMode.Open))
            {
                formatter.Serialize(fs, Services);
            }
        }

        public void Delete(Service service)
        {
            Services.Remove(service);

            var formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(_fileName, FileMode.Open))
            {
                formatter.Serialize(fs, Services);
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

    }
}
