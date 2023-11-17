﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week06._05Zoo
{
    internal class Enclosure
    {
        private string _Description;
        private string _Climate;
        private string _Name;
        private List<Animals> _AnimalsList;
        private bool _IsFed;

        public string Name
        {
            get => _Name;
            set => _Name = value;
        }
        public bool IsFed
        {
            get => _IsFed;
            set => _IsFed = value;
        }
        public List<Animals> Animals
        {
            get => _AnimalsList;
            
        }

        public string Description
        {
            get => _Description;
            set => _Description = value;
        }
        public Enclosure(string description, string climate, string name)
        {
            _Description = description;
            _Climate = climate;
            _Name = name;
            _AnimalsList = new List<Animals>();
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
            Console.WriteLine($"│   ├── {_Name}, {_Description}, {_Climate}");

            foreach (Animals animals in _AnimalsList)
            {
                animals.PrintZoo();

            }

        }
        public void PrintEnclosure()
        {
            Console.WriteLine($"│\t\t├── Enclosure: {_Name}");
            foreach (var animal in _AnimalsList)
            {
                animal.PrintAnimal();
            }
        }
        public void GetEnclosureStatistic(Dictionary <Food, double> dic)
        {
            foreach ( var animal in _AnimalsList)
            {
                animal.GetAnimalStatistic(dic);
            }

        }


        public override string ToString()
        {
            return "Enclosure22:" + _Name;
        }


    }
}
