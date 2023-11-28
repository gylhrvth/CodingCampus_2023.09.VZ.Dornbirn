using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week08.SelbstTestOOP
{
    public class Person
    {
        private string _name;
        private int _age;
        private string _gender;


        public Person(string Name, int Age, string Gender)
        {
            _name = Name;
            _age = Age;
            _gender = Gender;
        }

        public override string ToString()
        {
            string output = "";
            return output = $"Name: {_name} / Alter: {_age} / Geschlecht: {_gender}";


        }

        public string Name { get { return _name; } set { _name = value; } } 

        public int Age { get { return _age; } set { _age = value; } }

        public string Gender { get { return _gender;} set { _gender = value; } }
    }
}
