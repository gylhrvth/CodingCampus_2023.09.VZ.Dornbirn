
using System;

namespace Patrick.Week06.PersonOne
{
    public class Person
    {
        public float Height {  get; private set; }
        public int Age { get; private set; }
        public string Name { get; private set; }
        public float Weight { get; private set; }

      

        public Person(string name, int age, float size, float weight)
        {
            Height = size;
            Age = age;
            Name = name;
            Weight = weight;
        }

        //public override string ToString()
        //{
        //    return string.Format("{0}\nAge: {1}years\nHeight {2}cm\nWeight: {3}kg", _Name, _Age, _Size, _Weight);
        //    //return _Name;
        //}

    }
}
