using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patrick.Week06.Zoo;

namespace Patrick.Week06.Zoo
{
    internal class Enclosure
    {
        public string _Name { get; private set; }

        private List<Animals> _AnimalsList { get; set; }


        public Enclosure(string name)
        {
            _Name = name;
            _AnimalsList = new List<Animals>();
        }

        public List<Animals> AnimalsList
        {
            get => _AnimalsList;
            set => _AnimalsList = value;

        }

        public void PrintAnimals()
        {
            Console.WriteLine($"│   ├── Gehege: {_Name} ");
            foreach (Animals animal in _AnimalsList)
            {
                Console.WriteLine($"│       ├── {animal.Name}, {animal.Genus}, {animal.Age}");
            }                                   
        }


    }
}
