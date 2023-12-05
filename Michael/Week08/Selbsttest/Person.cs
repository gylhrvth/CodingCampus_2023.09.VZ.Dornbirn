using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week08.Selbsttest
{
    public enum Gender
    {
        Male, Female, Diverse
    }
    internal class Person
    {
        private string _Name;
        private int _Age;
        private Gender _Gender;

        public string Name { get => _Name; set => _Name = value; }
        public int Age { get => _Age; set => _Age = value; }
        public Gender Gender { get => _Gender;  set => _Gender = value; }

        public Person(string name, int age, Gender gender)
        {
            _Name = name;
            _Age = age;
            _Gender = gender;
        }

        public override string ToString()
        {
            return $"{_Name}, {_Gender}, {_Age} years";
        }
    }
}
