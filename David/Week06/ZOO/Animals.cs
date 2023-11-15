using System;
using System.Runtime.CompilerServices;

namespace David.Week06.ZOO
{
    public class Animals
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

        public void PrintAnimals()
        {
            if (_Food != null)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"      ||--> Name: {_Name}, Age: {_Age}, Type: {_Genus}, Sex: {_Gender}");

                foreach (Food foo in _Food)
                {
                    foo.PrintFood();
                }
            }
        }

    }


}


