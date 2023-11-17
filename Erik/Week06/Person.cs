using System;
using System.Xml.Linq;

namespace Erik.Week06
{
    public class Person
    {

        private int _Height;
        private int _Age;
        private string _Name;
        private int _Weight;

        
        public string Name { get => _Name; }
        public int Age { get => _Age; }

        public Person(int height, int age, string name, int weight)
        {
            _Height = height;
            _Age = age;
            _Name = name;
            _Weight = weight;
        }

        public override string ToString()
        {
            return String.Format("Name: {0}\nAge: {1}\nHeight: {2}cm\nWeight: {3}kgTrainer: {4}", _Name, _Age, _Height, _Weight);
        }
    }
}


//in Program.cs

//Person person = new Person(140, 14, "Peter", 50);
//Console.WriteLine(person);
//Person person2 = new Person(180, 24, "Sven", 80);
//Console.WriteLine(person2);




