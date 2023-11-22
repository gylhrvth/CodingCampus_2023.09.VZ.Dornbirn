using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Hassan.Week06
{
    public class Person
    {
        private string _Name;
        private int age;
        private int height;
        private double weight;

        public String Name {
            get => _Name;
            set
            {
                if (value != "")
                {
                    _Name = value;
                }
                else
                {
                    Console.WriteLine("Name must be non-empty.");
                }
            }
        }

        public int Age
        {
            get => age;
            set
            {
                if(value != null)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age must be non-empty.");
                }
            }
        }
       

        public Person(String name, int age, int height, double weight)
        {
            this._Name = name;
            this.age = age;
            this.height = height;
            this.weight = weight;
        }

        public override String ToString()
        {
            return "Name    : " + _Name + "\n" +
                    "Age     : " + age + " years old" + "\n" +
                    "Height  : " + height + " cm" + "\n" +
                    "Weight  : " + weight + "kg" + "\n";

        }

    }
}
