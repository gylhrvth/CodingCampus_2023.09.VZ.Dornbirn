using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week06.Zoo
{
    internal class Enclosure
    {
        private string _Description;
        private string _Name;
        private string _Climate;
        private bool _status;
        private List<Animal> _AnimalsList;

        public Enclosure(string name, string description, string climate, bool status)
        {
            _Name = name;
            _Climate = climate;
            _status = status;
            _AnimalsList = new List<Animal>();
            _Description = description;
        }

        public string Name
        {
            get => _Name;
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
            Console.WriteLine(Convert.ToChar(9556) + "" + Convert.ToChar(9565));
            Console.WriteLine(Convert.ToChar(9562) + "" + Convert.ToChar(9552) + "" + Convert.ToChar(9574) + $"Enclosure: {_Name}, {_Climate}");
            foreach (Animal animals in _AnimalsList)
            {
                animals.PrintZoo();
            }
        }
        public bool Status
        {
            get => _status;
            set
            {
                if (Status == true)
                {
                    Console.Write($"Enclosure {_Name} is clean.\n");
                }
                else
                {
                    Console.WriteLine($"Enclosure {_Name} is dirty.\n");
                }
                _status = value;

            }
        }

        public void SimulateDay()
        {
            Status = false;
            foreach (Animal animal in _AnimalsList)
            {
                animal.Hunger = true;
            }
        }

        public void FeedAnimalsAndClean()
        {
            Status = true;
            foreach (Animal animal in _AnimalsList)
            {
                animal.Hunger = false;
            }
        }
        public void Biting()
        {
            foreach (Animal animal in _AnimalsList)
            {
                if (ZooExample.r4.Next(101) < 40 && animal.Health > 0)
                {
                    animal.Biss = true;
                }
            }
        }

        public void BiteDamage()
        {

            foreach (Animal animal in _AnimalsList)
            {
                if (animal.Biss == true && animal.Health > 0)
                {
                    animal.Health -= (animal.Maxhealth / ZooExample.r4.Next(2, 10));
                }
                else if (animal.Health == animal.Health-- && animal.Biss == true && animal.Health > 0)
                {
                    Console.WriteLine($"{animal.Name} wurde gebissen!");
                }
            }

        }
        public void DeadAnimal()
        {
            for (int i = 0; i < _AnimalsList.Count; i++)
            {
                Animal ani = _AnimalsList[i];
                if (_AnimalsList.Contains(ani) && ani.Health <= 0)
                {
                    Console.WriteLine("Removed " + ani.Name);
                    _AnimalsList.RemoveAt(i);
                    --i;
                }
            }
        }
    }
}

