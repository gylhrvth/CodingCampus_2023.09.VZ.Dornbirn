using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week06.PersonExample
{
    public class Person
    {
        private double _Height;
        private int _Age;
        string _Name;
        private double _Weight;
        public double Height
        {
            get => _Height;

            set
            {
                Console.WriteLine("Die Größe wird geändert zu: " + value);
                _Height = value;
            }
        }
        public int Age
        {
            get => _Age;

            set
            {
                Console.WriteLine("Das Alter wird geändert zu: " + value);
                _Age = value;
            }
        }
        public string Name
        {
            get => _Name;
        }
        public double Weight
        {
            get => _Weight;

            set
            {
                Console.WriteLine("Das Gewicht wird geändert zu: " + value);
                _Weight = value;
            }
        }
        public Person(string Name, int Age, double Height, double Weight)
        {
            _Name = Name;
            _Age = Age;
            _Height = Height;
            _Weight = Weight;
        }
        public override string ToString()
        {
            return string.Format("Name: {0}\nAlter: {1}\nGröße: {2}m\nGewicht: {3}kg\n", _Name, _Age, _Height, _Weight);
        }

    }
}
