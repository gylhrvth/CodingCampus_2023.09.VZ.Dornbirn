using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet
{
    internal class Person
    {
            
        private int _Height;
        private int _Age;
        private string _Name;
        private int _Weight;


        public int Height
        {
            get => _Height;
            set
            { 
                Console.WriteLine($"Height is changed from {Height} to: " + value);
                _Height = value;
            }
        }
        public int Age
        {
            get => _Age;
            set
            {
                Console.WriteLine($"Age is changed from {Age} to: " + value);
                _Age = value;
            }
        }
        public string Name
        {
            get => _Name;
            set
            {
                Console.WriteLine($"Name was changed from {Name} to: " + value);
                _Name = value;
            }
        }


        public Person(int Height, int Age, string Name, int Weight)
        {
            _Height = Height;
            _Age = Age;
            _Name = Name;
            _Weight = Weight;
        }


        public override string ToString()
        {
            return string.Format(
                "Name: {0}\nAge: {1}\nHeight: {2}\nWeight: {3}",
                _Name,
                _Age,
                _Height,
                _Weight);

        }


    }
}
