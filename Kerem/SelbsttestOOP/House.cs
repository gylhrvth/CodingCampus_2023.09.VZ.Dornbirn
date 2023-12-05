using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.SelbsttestOOP
{
    internal class House
    {
        private int _doors;
        private int _windows;
        private string _adress;
        private List<Person> _people;

        public House(int doors, int windows, string adress)
        {
            _doors = doors;
            _windows = windows;
            _adress = adress;
            _people = new List<Person>();

        }
        public int doors
        {
            get => _doors;
            set => _doors = value;
        }
        public int windows
        {
            get => _windows;
            set => _windows = value;
        }
        public string adress
        {
            get => _adress;
            set => _adress = value;
        }
        public List<Person> people
        {
            get => _people;
            set => _people = value;
        }
        public virtual void AddPerson(Person person)
        {
            people.Add(person);
        }

        public override string ToString()
        {
            string houseInfo = $"Doors: {doors}, Windows: {windows}, Address: {adress}\nResidents:\n";

            foreach (Person people in _people)
            {
                houseInfo += people.ToString() + "\n";
            }
            return houseInfo;
        }

    }
}
