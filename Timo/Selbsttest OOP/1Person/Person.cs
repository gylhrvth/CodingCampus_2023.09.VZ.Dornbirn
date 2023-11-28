using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Selbsttest_OOP._1Person
{
    public enum Gender
    {
        female,
        male,
        divers
    }
    public class Person
    {
        private string _Name;
        private int _Age;
        private Gender _Gender;


        public Person(string name, int age, Gender gender)
        {
            _Name = name;
            _Age = age;
            _Gender = gender;
        }

        public string Name
        {
            get => _Name;
            set => _Name = value;
        }
        public int Age
        {
            get => _Age;
            set => _Age = value;
        }
        public Gender Gender
        {
            get => _Gender;
            set => _Gender = value;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}\nAlter: {1}\nGeschlecht: {2}", _Name,_Age,_Gender);
        }
    }
}
