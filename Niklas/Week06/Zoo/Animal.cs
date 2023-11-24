using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week06.Zoo
{
    internal class Animal
    {
        private string _Name;
        private int _Age;
        private string _Genus;
        private string _Gender;
        private bool _Hunger;
        private List<Food> _Food;
        private bool _Biss;
        private double _Health;
        private int _Maxhealth;
        private string _Favourite;

        public Animal(string name, int age, string genus, string gender, bool hunger, double health, bool Biss)
        {
            _Name = name;
            _Age = age;
            _Genus = genus;
            _Gender = gender;
            _Food = new List<Food>();
            _Hunger = hunger;
            _Health = health;
            _Maxhealth = 100;
            _Biss = Biss;
        }

        public string Name
        {
            get => _Name;
            set
            {
                _Name = value;
            }
        }
        public bool Biss
        {
            get => _Biss;
            set
            {
                _Biss = value;
            }
        }
        public double Health
        {
            get => _Health;
            set
            {
                if (value < 0) { value = 0; }
                Console.WriteLine($"{_Name}'s health is {value:N0}");
                _Health = value;
            }
        }
        public int Maxhealth
        {
            get => _Maxhealth;
        }

        public void AddFood(Food food)
        {

            if (!_Food.Contains(food))
            {

                _Food.Add(food);
            }
        }
        public bool Hunger
        {
            get => _Hunger;

            set
            {
                if (value == false)
                {

                    Console.WriteLine($"{_Name} is fed up!");
                }
                else
                {
                    Console.WriteLine($"{_Name} is hungry!");
                }
                _Hunger = value;
            }
        }

        public void PrintZoo()
        {
            Console.WriteLine("  " + Convert.ToChar(9553) + "  " + Convert.ToChar(9562) + "" + Convert.ToChar(9552) + $"{_Name}, {_Age}, {_Gender}, {_Genus}");
            foreach (Food food in _Food)
            {
                food.PrintZoo();

            }
        }

    }
}
