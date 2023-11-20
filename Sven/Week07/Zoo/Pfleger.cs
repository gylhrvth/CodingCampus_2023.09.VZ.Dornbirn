using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sven.Week07.Zoo.Zoo
{
    internal class Keeper
    {

        private string _Name;
        private List<Enclosure> _Enclosures = new();

        public List<Enclosure> Enclosures
        {
            get => _Enclosures;
            set => _Enclosures = value;
        }

        public Keeper(string name, List<Enclosure> enclosures)
        {

            _Name = name;
            _Enclosures = enclosures;

        }


        public override string ToString()
        {
            return "Name: " + _Name;
        }

        public void PrintFoodSimulation()
        {
            foreach (Enclosure enclosure in Enclosures)
            {
                foreach (Animal animal in enclosure.Animals)
                {
                    Console.WriteLine($"Keeper {_Name} is responsilbe for enclosure {enclosure.Description} and feeds {animal.Name}");
                }
            }

        }


    }
}
