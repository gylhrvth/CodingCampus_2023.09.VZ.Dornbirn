using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week08.Obj_Selbsttest.OOP
{
    public class Person
    {
        private string _Name;
        private int _Age;
        private Gender _Gender;

        public string Name
        {
            get => _Name; set => _Name = value;
        }
        public int Age
        {
            get => _Age; set { _Age = value; }
        }
        public Gender Gender
        {
            get => _Gender; set { _Gender = value; }
        }


        public Person(string name, int age, Gender gender)
        {
            _Name = name;
            _Age = age;
            _Gender = gender;
        }
        public override string ToString()
        {
            return string.Format("Person: {0}, {1} ({2})", _Name, _Age, _Gender);
        }
    }
    public enum Gender
    {
        male,
        female,
        diverse
    }
}
