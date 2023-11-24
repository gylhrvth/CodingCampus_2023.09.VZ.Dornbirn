using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Week06.Zoo
{
    internal class Enclosure
    {
        private string _Description;
        private string _Climate;
        private string _Name;
        private List<Animal> _AnimalsList;

        public Enclosure(string description, string climate, string name)
        {
            _Description = description;
            _Climate = climate;
            _Name = name;
            _AnimalsList = new List<Animal>();
        }

        public void AddAnimals(Animal animals)
        {

            if (!_AnimalsList.Contains(animals))
            {

                _AnimalsList.Add(animals);
            }
        }



        public void PrintZoo()
        {
            Console.WriteLine($"│ ├── Enclosure: {_Name}, {_Description}, {_Climate}");

            foreach (Animal animals in _AnimalsList)
            {
                animals.PrintZoo();

            }

        }



    }
}

