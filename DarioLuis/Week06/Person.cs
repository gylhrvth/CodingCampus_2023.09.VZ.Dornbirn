using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Week06
{
    public class Person
    {
        public string Name { get; set; }
        private int Age { get; set; }

        private int Height { get; set; }

        private int Weight { get; set; }

        public Person(string name, int age, int height, int weight) 
        {
            Name = name;
            Age = age;
            Height = height;
            Weight = weight;
        }
        public override string ToString()
        {
            return "person: " + Name + " " + Age + " " + Height + "cm " + Weight + "kg";
        }
    }
}
