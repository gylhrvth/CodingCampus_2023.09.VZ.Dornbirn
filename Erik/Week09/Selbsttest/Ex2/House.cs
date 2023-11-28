using Erik.Week06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erik.Week09.Selbsttest.Ex2
{
    public class House
    {
        private int _Doors;
        private int _Windows;
        private string _Address;
        List<Person> _PersonList;

        public int doors { get => _Doors; set => _Doors = value; }
        public int windows { get => _Windows; set => _Windows = value; }
        public string address { get => _Address; set => _Address = value; }
       

        public House(int doors, int windows, string address, List<Person> personList)
        {
            _Doors = doors;
            _Windows = windows;
            _Address = address;
            _PersonList = new List<Person>();
        }

        public void AddPerson(Person person)
        {
            _PersonList.Add(person);
        }
        
        public override string ToString()
        {
            Person person = null;
            return $"This house of {person.Name} has {_Doors} doors and {_Windows} windows. The address is: {address}";
        }
    }
}
