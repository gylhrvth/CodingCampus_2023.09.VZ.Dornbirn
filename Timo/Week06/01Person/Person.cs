using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week06._01Person
{
    public class Person
    {
        private int _Height;
        private int _Age;
        private string _Name;
        private double _Weight;

        public Person(int Height, int Age, string Name, double Weight)
        {
            _Height = Height;
            _Age = Age;
            _Name = Name;
            _Weight = Weight;
        }

        public int Height
        {
            get { return _Height; }
            set { if (value > 0) { Console.WriteLine("Height is changing to: " + value); _Height = value; }
                else { Console.WriteLine("Height can't be lower than 0"); }
            }
        }
        public int Age
        {
            get { return _Age; }
            set
            {
                if (value > 0) { Console.WriteLine("Age is changing to: " + value); _Age = value; }
                else { Console.WriteLine("Age can't be lower than 0"); }
            }
        }
        public string Name { get { return _Name; } }
        public double Weight
        {
            get { return _Weight; }
            set { if (value > 0) { Console.WriteLine("Weight is changing to: " + value); _Weight = value; }
                else { Console.WriteLine("Weight can't be lower than 0"); }
            }
        }
        public override string ToString()
        {
            return string.Format("Name is: {0,-10} -\tAge is: {1,-10} - \tHeight is: {2,-8} -\tWeight is: {3}",
                _Name,
                _Age + " Years",
                _Height + " cm",
                _Weight + " kg");
        }
    }
}
