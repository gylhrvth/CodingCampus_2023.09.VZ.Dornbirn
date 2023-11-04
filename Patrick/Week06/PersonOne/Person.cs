
using System;

namespace Patrick.Week06.PersonOne
{
    public class Person
    {
        private double _Size;
        private int _Age;
        private string _Name;
        private double _Weight;

        public double Size { get => _Size;  }

        public Person(double size, int age, string name, double weight)
        {
            _Size = size;
            _Age = age;
            _Name = name;
            _Weight = weight;
        }

        public override string ToString()
        {
            //return string.Format("{0}\nAge: {1}years\nHeight {2}cm\nWeight: {3}kg", _Name, _Age, _Size, _Weight);
            return _Name;
        }
        
    }
}
