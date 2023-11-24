using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandro.Week06.ZooTycoon
{
    internal class Enclosure
    {
        private string _Description;
        private string _Climate;
        private string _Name;
        private List<Animals> _AnimalsList;

        public Enclosure(string description, string climate, string name)
        {
            _Description = description;
            _Climate = climate;
            _Name = name;
            _AnimalsList = new List<Animals>();
        }

        public void AddAnimals(Animals animals) {

            if (!_AnimalsList.Contains(animals))
            {

                _AnimalsList.Add(animals);
            }
            else {
                Console.WriteLine($"{animals} ist schon da");
            }
               
        }

        override
        public string ToString()
        {
            return base.ToString();
        }

        public void PrintZoo() {
            Console.WriteLine($" ---  Enclosure: {_Name}, {_Description}, {_Climate}");

            foreach(Animals animals in _AnimalsList)
            {
                animals.PrintZoo();

            }

        }



    }
}
