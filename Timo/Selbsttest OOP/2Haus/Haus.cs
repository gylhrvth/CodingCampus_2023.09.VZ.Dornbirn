using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timo.Selbsttest_OOP._1Person;


namespace Timo.Selbsttest_OOP._2Haus
{
    public class Haus
    {
        private int _Doors;
        private int _Windows;
        private string _Address;
        private List<Person> _Persons = new();

        public Haus(int doors, int windows, string address)
        {
            _Doors = doors;
            _Windows = windows;
            _Address = address;
        }

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
        public string Address
        {
            get => _Address;
            set => _Address = value;
        }
        public List<Person> Persons
        {
            get => _Persons;
            set => _Persons = value;
        }

        public virtual void AddPerson(Person person)
        {
            _Persons.Add(person);
        }
        public void PersonToString(List<Person> _Persons)
        {
            foreach (Person person in _Persons)
            {
                Console.WriteLine(person.ToString() + "\n");
            }
        }
        

        public override string ToString()
        {
            string personList =  string.Join(", ", _Persons.Select(person => person.Name));
            return string.Format("Anzahl Türen: {0}\nAnzahl Fenster: {1}\nAdresse: {2}\nListe an Personen in diesem Haus: {3}", _Doors, _Windows, _Address, personList);
        }
    }
}
