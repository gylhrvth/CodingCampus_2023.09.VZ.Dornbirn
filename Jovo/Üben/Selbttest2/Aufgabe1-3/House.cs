using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Jovo.Üben.Selbttest2.Aufgabe2
{
    internal class House
    {
        private int _doors;
        private int _windows;
        private string _adress;
        private List<Person> _residents;



        public House(int doors, int windows, string adress) 
        {
            _doors = doors;
            _windows = windows;
            _adress = adress;
            _residents = new List<Person>();
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

        public  List<Person> residents
        {
            get => _residents; 
            set => _residents = value;
        }

        public virtual void AddPerson(Person person)
        {
            residents.Add(person);

        }

        public override string ToString()
        {
            //string enthält die infos vom Haus
            string houseInfo = $"Doors: {doors}, Windows: {windows}, Address: {adress},\nResidents:\n";

            //Füge die personen im Haus ein
            foreach (Person resident in residents)
            {
                houseInfo += resident.ToString() + "\n";
            }

            return houseInfo;
        }
    }
}
