using System;
using System.Threading.Channels;

namespace Erik.Week08
{
    public class Animal
    {
        private string _AnimalName;
        private string _Genus;
        private string _Gender;
        private Food _Food;

        public Animal(string animalName, string genus, string gender, Food food)
        {
            _AnimalName = animalName;
            _Genus = genus;
            _Gender = gender;
            _Food = food;
        }

        public void PrintAnimalHunger(string prefix)
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 101);

            if (random >= 50)
            {
                Console.Write(prefix + "─────── {0} ", _AnimalName);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("not very hungry! ({0}% left!)", random);
                Console.ResetColor();
            }
            else if (random < 50 && random > 10)
            {
                Console.Write(prefix + "─────── {0} ", _AnimalName);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("is hungry! ({0}% left!)",random);
                Console.ResetColor();
            }
            else if (random <= 10)
            {
                Console.Write(prefix + "─────── {0} is ", _AnimalName);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("VERY hungry! ({0}% left!)",random );
                Console.ResetColor();
            }
        }

        public void PrintAnimal(string prefix)
        {
            Console.WriteLine("{0} {1}, {2}, {3}", prefix, _AnimalName, _Genus, _Gender);
        }


    }
}
