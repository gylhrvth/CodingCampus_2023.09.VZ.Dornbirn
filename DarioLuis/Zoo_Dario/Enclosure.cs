﻿using DarioLuis.Zoo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Zoo_Dario
{
    public class Enclosure
    {
        private readonly Random random = new Random();
        private string _Name;
        private List<Animal> _Animals;
        private bool _IsFed;


        public string Name
        {
            get => _Name; 
            set => _Name = value;
        }

        public List<Animal> Animals
        {
            get => _Animals;
            set => _Animals = value;
        }
        public bool IsFed
        {
            get => _IsFed;
            set => _IsFed = value;
        }

        public Enclosure(string name)
        {
            _Name = name;
            _Animals = new List<Animal>();
            _IsFed = false;
        }
        public void Fight(List<Animal> animalsToRemove)
        {
            foreach (var animal in _Animals)
            {
                foreach (var other in _Animals)
                {
                    if (!animal.IsDead && !other.IsDead && other != animal && random.NextDouble() <= 0.4)
                    {
                        Console.WriteLine($"{animal.Name} bit {other.Name} and did {animal.Damage} damage");
                        other.Health -= animal.Damage;

                        if (other.Health <= 0)
                        {
                            other.IsDead = true;
                            Console.WriteLine($"{other.Name} died");
                            animalsToRemove.Add(other);
                        }
                    }

                }
            }
        }
        public void PrintEnclosure()
        {
            Console.WriteLine($"│\t\t├── Enclosure: {_Name}");
            foreach (var animal in _Animals)
            {
                animal.PrintAnimal();
            }
        }
        public void GetEnclosureStatistic(Dictionary<Food, double> dic)
        {
            foreach (var animal in _Animals)
            {
                animal.GetAnimalStatistic(dic);
            }
        }
        public override string ToString()
        {
            return "Enclosure: " + _Name;
        }
    }
}
