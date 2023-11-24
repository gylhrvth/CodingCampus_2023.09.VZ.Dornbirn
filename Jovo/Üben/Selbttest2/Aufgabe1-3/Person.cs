using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Üben.Selbttest2.Aufgabe2
{
    internal class Person
    {


        private string _name;
        private int _age;
        private string _gender;



        public Person(string name, int age, string gender)
        {
            _name = name;
            _age = age;
            _gender = gender;

        }

        public string name
        {
            get => _name;
            set => _name = value;
        }


        public int age
        {
            get => _age;
            set => _age = value;
        }


        public string gender
        {
            get => _gender;
            set => _gender = value;
        }

        public override string ToString()
        {
            return $"Name: {name}, Age: {age}, Gender:{gender}";

        }
    }
}
