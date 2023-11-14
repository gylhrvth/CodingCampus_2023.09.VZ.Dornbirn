using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace David.Week06.Person2
{
    public class Person
    {
        private string _Name;
        private int _Age;
        private int _Height;
        private int _Weight;

        public int Height { get => _Height; }
        public string Name { get => _Name; }

        public Person(string name, int age, int hight, int weight)
        {
            _Name = name;
            _Age = age;
            _Height = hight;
            _Weight = weight;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}\nAge: {1}\nHight: {2}\nWeight: {3}",
            _Name,
            _Age,
            _Height,
            _Weight);
        }

    }
}

