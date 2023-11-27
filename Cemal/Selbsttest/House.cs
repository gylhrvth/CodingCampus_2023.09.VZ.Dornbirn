using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Selbsttest.Aufgabe1
{
    public class House
    {
        private int _Doors;
        private string _Address;
        private int _Windows;
        List<Person> _Person;

        public House(int doors, string address, int windows)
        {
            _Doors = doors;
            _Address = address;
            _Windows = windows;
            _Person = new List<Person>();
        }

        public void addPerson(Person pers)
        {
            _Person.Add(pers);
        }

        public void PrintStructure()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Das Haus mit der Adresse: {_Address} hat {_Doors} Türen, {_Windows} Fenstern");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Die Personen wohnen hier:");

            foreach (Person person in _Person)
            {
                Console.ForegroundColor= ConsoleColor.White;
                person.PrintStructure();
            }
        }


    }
}
