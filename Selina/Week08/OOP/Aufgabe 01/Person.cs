using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selina.Week08.OOP.Aufgabe1
{
    public class Person
    {
        private string Name;
        private int Age;
        private Gender Gender;

        public string name
        {
            get => Name;
            set => Name = value;
        }
        public int age
        {
            get => Age;
            set => Age = value;
        }
        public Gender gender
        {
            get => Gender;
            set => Gender = value;
        }

        public Person(string Name, int Age, Gender Gender) 
        {
            this.Name = Name;
            this.Age = Age;
            this.Gender = Gender;
        }
 
        public override string ToString()
        {
            return $"Name = {name}, Age '= {age}, Gender = {gender}";
        }

    }
}
