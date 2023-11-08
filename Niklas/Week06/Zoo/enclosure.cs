using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week06.Zoo
{
    internal class enclosure
    {
        private string _Description;
        private string _Name;
        private string _Climate;
        private List<Animals> _AnimalsList;

        public enclosure(string name, string description ,string climate)
        {
            _Name = name;
            _Climate = climate;
            _AnimalsList = new List<Animals>();
            _Description = description;
        }

        public void AddAnimals(Animals animals)
        {

            if (!_AnimalsList.Contains(animals))
            {

                _AnimalsList.Add(animals);
            }
        }

        public void PrintZoo()
        {
            Console.WriteLine(Convert.ToChar(9556) + "" + Convert.ToChar(9565));
            Console.WriteLine(Convert.ToChar(9562) + "" + Convert.ToChar(9559) + $"Enclosure: {_Name}, {_Climate}");
            foreach (Animals animals in _AnimalsList)
            {
                animals.PrintZoo();

            }
        }
    }
}
