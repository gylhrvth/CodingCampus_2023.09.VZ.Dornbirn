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
    internal class Animals
    {
        private string _Name;
        private int _Age;
        private string _Genus;
        private string _Gender;
        private string _Hunger;
        private List<Food> _Food;

        public Animals(string name, int age, string genus, string gender, string hunger)
        {
            _Name = name;
            _Age = age;
            _Genus = genus;
            _Gender = gender;
            _Food = new List<Food>();
            _Hunger = hunger;
        }

        public void AddFood(Food food)
        {

            if (!_Food.Contains(food))
            {

                _Food.Add(food);
            }
        }
        public string Hunger
        {
            get => _Hunger;

            set
            {
                Console.WriteLine($"{_Name} is now {value}!");
                _Hunger = value;
            }
        }

        public void PrintZoo()
        {
            Console.WriteLine("  " + Convert.ToChar(9553) + Convert.ToChar(9562) + "" + Convert.ToChar(9552) + $"{_Name}, {_Age}, {_Gender}, {_Genus}, {_Hunger}");
            foreach (Food food in _Food)
            {
                food.PrintZoo();

            }
        }
    }
}
