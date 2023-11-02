using System;

namespace Patrick
{
    public class Person
    {
        private double _Size;
        private int _Age;
        private string _Name;
        private double _Weight;



        public Person(double Size, int Age, string Name, double Weight)
        {
            _Size = Size;
            _Age = Age;
            _Name = Name;
            _Weight = Weight;
        }

        public override string ToString()
        {
            return string.Format("{0}\nAge: {1}years\nHeight {2}cm\nWeight: {3}kg", _Name, _Age, _Size, _Weight);
        }
    }
}
