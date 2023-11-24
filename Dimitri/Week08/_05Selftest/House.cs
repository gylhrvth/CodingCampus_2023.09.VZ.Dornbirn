using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week08._05Selftest
{
    internal class House
    {
        private int _Doors;
        private int _Windows;
        private string _Adresse;
        private List<Person> _Persons = new();

        public int Doors
        {
            get => _Doors;
            set => _Doors = value;
        }

        public int Windows
        {
            get => _Windows; 
            set => _Windows = value;
        }

        public string Adresse
        {
            get => _Adresse; 
            set => _Adresse = value;
        }

        public List<Person> Persons
        {
            get => _Persons;
            set => _Persons = value;

        }

        public House(int doors, int windows, string adresse)
        {
            _Doors = doors;
            _Windows = windows;
            _Adresse = adresse;
        }

        public string ToString()
        {
            return string.Format("Nr. of Doors: {0} Nr. of Windows: {1} Adresse: {2}", _Doors, _Windows, _Adresse);
        }

        public void AddPerson(Person person)
        {
            _Persons.Add(person);
        }
    }
}
