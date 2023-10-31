using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hassan.Week06
{
    public class Person
    {
        private String name;
        private int age;
        private int height;
        private double weight;

        public Person(String name, int age, int height, double weight)
        {
            this.name = name;
            this.age = age;
            this.height = height;
            this.weight = weight;
        }

        public String toString()
        {
            return "Name    : " + name + "\n" +
                    "Age     : " + age + " years old" + "\n" +
                    "Height  : " + height + " cm" + "\n" +
                    "Weight  : " + weight + "kg" + "\n";

        }






        public static void Start()
        {
            Person person = new Person("Hassan", 21, 188, 80);
            Console.WriteLine(person.toString());
        }

    }
}
