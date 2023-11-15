using System;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace Erik.Week08
{
    public class Animal
    {
        private string _AnimalName;
        private string _Genus;
        private string _Gender;
        private Food _Food;
        private int _Hunger;

        public Food food { get => _Food;  }
    
        public int hunger { get => _Hunger; set => _Hunger = value; }

        public Animal(string animalName, string genus, string gender, Food food)
        {
            _AnimalName = animalName;
            _Genus = genus;
            _Gender = gender;
            _Food = food;
            Random rnd = new Random();
            _Hunger = rnd.Next(1, 101);
        }

        public void PrintAnimalHunger(string prefix)
        {
            if (_Hunger >= 50)
            {
                Console.Write(prefix + "─────── {0} ", _AnimalName);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("not very hungry! ({0} units left!)", _Hunger);
                Console.ResetColor();
            }
            else if (_Hunger < 50 && _Hunger > 10)
            {
                Console.Write(prefix + "─────── {0} ", _AnimalName);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("is hungry! ({0} units left!)",_Hunger);
                Console.ResetColor();
            }
            else if (_Hunger <= 10)
            {
                Console.Write(prefix + "─────── {0} is ", _AnimalName);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("VERY hungry! ({0} units left!)",_Hunger );
                Console.ResetColor();
            }
        }

        public void PrintAnimal(string prefix)
        {
            Console.WriteLine("{0} {1}, {2}, {3}", prefix, _AnimalName, _Genus, _Gender);
        }


    }
}
