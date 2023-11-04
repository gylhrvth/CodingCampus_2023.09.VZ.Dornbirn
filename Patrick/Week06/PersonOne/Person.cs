
using System;

namespace Patrick.Week06.PersonOne
{
    public class Person
    {
        public double _Size {  get; private set; }
        public int _Age { get; private set; }
        public string _Name { get; private set; }
        public double _Weight { get; private set; }



        public Person(string name, int age, double size, double weight)
        {
            _Size = size;
            _Age = age;
            _Name = name;
            _Weight = weight;
        }

        //public override string ToString()
        //{
        //    return string.Format("{0}\nAge: {1}years\nHeight {2}cm\nWeight: {3}kg", _Name, _Age, _Size, _Weight);
        //    //return _Name;
        //}

    }
}
