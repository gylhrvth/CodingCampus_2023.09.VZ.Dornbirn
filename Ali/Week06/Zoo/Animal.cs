using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Week06.Zoo
{
    internal class Animal
    {
        private string _Name;
        private int _Age;
        private string _Genus;
        private string _Gender;
        private Food _Food;
        private int _FoodAmount;

        public Animal(string name, int age, string species, string gender, Food food, int foodAmount)
        {
            _Name = name;
            _Age = age;
            _Genus = species;
            _Gender = gender;
            _Food = food;
            _FoodAmount = foodAmount;
        }


        public void PrintZoo()
        {
            Console.WriteLine($"│   ├── {_Name},{_Age},{_Gender},{_Genus}, eats : {_FoodAmount} {_Food}");
        }
    }
}
