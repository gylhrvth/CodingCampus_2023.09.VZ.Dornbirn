using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week06.Zoo
{
    internal class Enclosure
    {
        private string _Description;
        private string _Name;
        private string _Climate;
        private string _status;
        private List<Animals> _AnimalsList;

        public Enclosure(string name, string description, string climate, string status)
        {
            _Name = name;
            _Climate = climate;
            _status = status;
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
            Console.WriteLine(Convert.ToChar(9562) + "" + Convert.ToChar(9552) + "" + Convert.ToChar(9574) + $"Enclosure: {_Name}, {_Climate}, is {_status}");
            foreach (Animals animals in _AnimalsList)
            {
                animals.PrintZoo();

            }
        }
        public string Status
        {
            get => _status;
            set
            {
                Console.WriteLine();
                Console.Write($"Enclosure {_Name} is now: {value}. ");
                _status = value;

            }
        }
    }
}
