using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.SelbstTest
{
    public class House
    {
        private string _Adress;
        private int _Doors;
        private int _Windows;
        List<Person> personList = new List<Person>();

        public string Adress { get { return _Adress; } }
        public int Doors { get { return _Doors; } }
        public int Windows { get { return _Windows; } }

        public House(string adress, int doors, int windows)
        {
            _Adress = adress;
            _Doors = doors;
            _Windows = windows;
            
        }

        public void PrintPersonFromList()
        {
            Console.WriteLine("---- Personen ----");
            foreach (Person person in personList)
            {
                Console.WriteLine(person);
            }
        }

        public virtual void AddPerson(Person person) 
        {
            personList.Add(person);
        }



        public override string ToString() 
        {
            return string.Format($"\n---- Haus ----\nAdress: {_Adress}\nDoors: {_Doors}\nWindows: {_Windows}");
        }

    }
}
