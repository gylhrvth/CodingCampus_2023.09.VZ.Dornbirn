using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week08.SelbstTestOOP
{
    public class House
    {
        private List<Person> _personList = new();

        private string _name;
        private string _color;
        private string _material;
        private string _address;

        public House(string Name, string Color, string Material, string Address)
        {
            _name = Name;
            _color = Color;
            _material = Material;
            _address = Address;
        }

        public string Name { get { return _name; } set { _name = value; } }
        public string Color { get { return _color; } set { _color = value; } }
        public string Material { get { return _material; } set { _material = value; } }
        public string Address { get { return _address; } set { _address = value; } }


        public void AddPerson(Person person)
        {
            _personList.Add(person);
        }

        public override string ToString()
        {
            string output = $"";

            Console.WriteLine($"HouseName: {_name} /  HouseColor: {_color} / HouseMaterial: {_material} / Address: {_address} / ");

            if (_personList.Count == 0)
            {
                return output = "(leer)";
            }

            for (int i = 0; i < _personList.Count; i++ )
            {
                output += "\n" + _personList[i];
            }

            return output;
               
        }
    }
}
