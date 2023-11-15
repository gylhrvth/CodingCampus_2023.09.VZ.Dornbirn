using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week06._01Person
{
    public class Person
    {
        private float _Height;
        private int _Age;
        private string _Name;
        private float _Weight;

        public float Height
        {
            get { return _Height; }
        }

        public float Weight
        {
            get { return _Weight; }
        }

        public string Name
        {
            get { return _Name; }
        }

        public int Age
        {
            get { return _Age; }
        }
        public Person(float Height, int Age, string Name, float Weight)
        {
            _Height = Height;
            _Age = Age;
            _Name = Name;
            _Weight = Weight;
        }

        public override string ToString()
        {
            return string.Format("Name: {2}\nGröße: {0} cm\nAlter: {1} Jahre\nGewicht: {3} kg", _Height, _Age, _Name, _Weight);
        }
    }
}
