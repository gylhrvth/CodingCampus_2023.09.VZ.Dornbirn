using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erik.Week09.Selbsttest.Ex1
{
    public class Person
    {
        private string _Name;
        private int _Age;
        public enum _Gender { male, female, divers };
        private _Gender _PersonGender;


        public string name { get => _Name; set => _Name = value; }
        public int age { get => _Age; set => _Age = value; }
        public _Gender personGender { get => _PersonGender; set => _PersonGender = value; }


        public Person(string name, int age, _Gender gender)
        {
            _Name = name;
            _Age = age;
            personGender = gender;
        }


        public override string ToString()
        {
            return $"{_Name} / {_PersonGender} / {_Age}";
        }
    }
}
