using System;
using System.Net;

namespace Mohammed.Week08.UebungOOP
{
    public class House : Persons
    {
        private int _Door;
        private int _Windows;
        private string _Address;
        private List<Persons> persons = new List<Persons>();

        private int Door
        {
            get => _Door;
            set { Door = value; }
        }

        private int Windows
        {
            get => _Windows;
            set { Windows = value; }

        }

        private string Address
        {
            get => _Address;
            set { Address = value; }
        }

        public House(int door, int windos, string address, string name, int age, string gender) : base(name, age, gender)
        {
            _Door = door;
            _Windows = windos;
            _Address = address;
            //_Listperson = new List<Person>();
        }

        public void AddPerson(Persons person)
        {
            persons.Add(person);
        }

        public string ToString()
        {
            return $"Haus mit {Door} Türen, {Windows} Fenstern und der Adresse {Address}. Bewohnt von: {persons.ToString}";
            //return string.Format("Door: {0}\n Windows: {1}\n Address{3}", _Door, _Windows, _Address);
        }
}    }
