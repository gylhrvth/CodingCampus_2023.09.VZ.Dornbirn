using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.SelbsttestOOP
{
    internal class Person
    {
        private string _name;
        private int _age;

        public enum Genders
        {
            male,
            female,
            divers
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public Genders Gender { get; set; }
     
        public Person(string name, int age, Genders gender)
        {
            _name = name;
            _age = age;
            Gender = gender;
        }
        public override string ToString()
        {
            return $"Person {_name}, is {_age} years old, and is {Gender}";
        }
    }
}
