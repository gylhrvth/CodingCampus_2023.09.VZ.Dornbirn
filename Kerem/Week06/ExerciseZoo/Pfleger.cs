using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Kerem.Week06.ExerciseZoo
{
    internal class Pfleger
    {
        private Random rand = new Random();

        private string _name;
        private List<Enclosure> _enclosure = new();
        private string _favouriteanimal;
        private bool _isfed = false;

        public List<Enclosure> Enclosure
        {
            get => _enclosure;
            set => _enclosure = value;
        }
        public string FavouriteAnimal
        {
            get => _favouriteanimal;
            set => _favouriteanimal = value;
        }


        public Pfleger(string name, List<Enclosure> enclosure)
        {
            _name = name;
            _enclosure = enclosure;
            _favouriteanimal = FavouriteAnimal;
        }
        public void PrintZooPfleger()
        {
            Console.Write($"│   ├──ZooPfleger name: {_name} ist zuständig für:");

            foreach (var enclosure in _enclosure)
            {
                Console.Write($" {enclosure.Name}");
            }
            Console.WriteLine();
        }
        public override string ToString()
        {
            return "Name: " + _name;
        }
        public void PrintFoodSimulation()
        {
            foreach (Enclosure enclosure in _enclosure)
            {
                foreach (Animals animal in enclosure.AnimalsList)
                {
                    if (enclosure.IsFed == false)
                    {

                        Console.WriteLine($"{animal.Genus} is HUNGRY!! {_name} feeds {animal.Genus} with the name {animal.Name}, with the {animal.Food}\n{animal.Genus} is now satisfied: {animal.Sound}");
                        enclosure.ObserveAnimals(_favouriteanimal);

                    }

                }

                enclosure.IsFed = true;
            }


        }

        public void Simulate()
        {
            PrintFoodSimulation();
        }

    }
}
