using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week06.ExerciseZoo
{
    internal class Enclosure
    {
        private string _Description;
        private string _Name;
        private string _Climate;
        private List<Animals> _AnimalsList;
        

        public Enclosure(string name, string description, string climate)
        {
            _Name = name;
            _Description = description;
            _Climate = climate;
            _AnimalsList = new List<Animals>();
        }
        public void addAnimals(Animals animals)
        {
            _AnimalsList.Add(animals);
        }
        public void PrintZoo()
        {
            Console.WriteLine($"│   ├── {_Name}, {_Description}, {_Climate}");

            foreach(Animals animals in _AnimalsList)
            {
                animals.PrintZoo();
            }
            
        }

    }
}
