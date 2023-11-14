using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week07.Krankenhaus
{
    internal class Patient
    {
        private string _Name;
        private int _Age;
        private string _Description;
        private string _Health;

        public string Name
        {
            get => _Name;
            set
            {
                Console.WriteLine($"--- ---The patients name is {value}.");
                _Name = value;
            }
        }
        public int Age
        {
            get => _Age;
            set
            {
                Console.WriteLine($"--- ---He is {value} years old.");
                _Age = value;
            }
        }
        public string Health
        {
            get => _Health;


            set
            {
                Console.WriteLine($"--- ---Person needs to be in the {value}");
                _Health = value;
            }
        }
        public Patient(string name, int age, string health)
        {
            _Name = name;
            Age = age;
            Health = health;
        }



    }
}
