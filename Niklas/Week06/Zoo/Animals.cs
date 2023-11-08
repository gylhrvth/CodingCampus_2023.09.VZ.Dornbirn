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
        private List<Food> _Food;

        public Animals(string name, int age, string genus, string gender)
        {
            _Name = name;
            _Age = age;
            _Genus = genus;
            _Gender = gender;
            _Food = new List<Food>();
        }

        public void AddFood(Food food)
        {

            if (!_Food.Contains(food))
            {

                _Food.Add(food);
            }
        }

        public void PrintZoo()
        {
            Console.WriteLine(" " + Convert.ToChar(9568) + "" + Convert.ToChar(9552) + $"{_Name}, {_Age}, {_Gender}, {_Genus}");
            foreach (Food food in _Food)
            {
                food.PrintZoo();

            }
        }
    }
}
