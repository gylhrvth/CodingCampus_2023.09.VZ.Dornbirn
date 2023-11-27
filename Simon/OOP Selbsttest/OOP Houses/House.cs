using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.OOP_Selbsttest.OOP_Houses
{
    public class House
    {
        private int _Doors;
        private int _Windows;
        private string _Adress;
        private List<Person> _PersonList;

        public int Doors
        {
            get { return _Doors; }
            set { _Doors = value; }
        }
        public int Windows
        {
            get { return _Windows; }
            set { _Windows = value; }
        }
        public string Adress
        {
            get { return _Adress; }
            set { _Adress = value; }
        }
        public List<Person> PersonList
        {
            get { return _PersonList; }
            set { _PersonList = value; }
        }

        public House(string adress, int doors, int windows)
        {
            _Doors = doors;
            _Windows = windows;
            _Adress = adress;
            _PersonList = new List<Person>();
        }

        public virtual void AddPerson(Person person)
        {
            _PersonList.Add(person);
        }

        public override string ToString()
        {
            string personListString = string.Join(", ", _PersonList.Select(person => person.Name));
            return string.Format("Das Haus an der Adresse {0} hat {1} Fenster und {2} Türen. Die Bewohner des Hauses sind {3}", _Adress, _Windows, _Doors, personListString);
        }



    }
}
