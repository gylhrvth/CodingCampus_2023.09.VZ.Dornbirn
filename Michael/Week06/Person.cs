using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week06
{
    public class Person
    {
        private int _Size;
        private int _Age;
        private string _Name;
        private double _Weight;

        public string Name { get => _Name; }
        public double Weight { get => _Weight; }
        public int Size { get => _Size; }
        public int Age { get => _Age; }

        public Person(int size, int age, string name, double weight)
        {
            _Size = size;
            _Age = age;
            _Name = name;
            _Weight = weight;
        }

        public override string ToString()
        {
            return $"Name:   {_Name}\nAge:    {_Age}\nSize:   {_Size}cm\nWeight: {_Weight}kg";
        }
    }
}
