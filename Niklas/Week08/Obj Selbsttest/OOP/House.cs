using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Niklas.Week08.Obj_Selbsttest.OOP
{
    internal class House
    {
        private int _Door;
        private int _Window;
        private string _Address;
        private List<Person> _Person;

        public int Doors
        {
            get => _Door; set => _Door = value;
        }
        public int Window
        {
            get => _Window; set => _Window = value;
        }
        public string Address
        {
            get => _Address; set => _Address = value;
        }
        public List<Person> Person
        {
            get => _Person; set => _Person = value;
        }
        public House(int door, int window, string address, List<Person> people)
        {
            _Door = door;
            _Window = window;
            _Address = address;
            _Person = people;
        }

        public void AddPerson(Person person)
        {
            if (!_Person.Contains(person))
            {
                _Person.Add(person);
            }
        }
        public override string ToString()
        {
            return string.Format("House: {0}, ({1})", _Door, _Address);
        }
    }
}
