using System;
using System.Runtime.CompilerServices;

namespace David.Week06.ZOO
{
    internal class Animals
    {
        private string _Name;
        private string _Genus;
        private int _Age;
        private string _Gender;
        private float _FoodAmount;
        private int _MaxHealthRate;
        private int _BitePower;
        private Food _Food;
        private List<Food> _FoodList;

        //Properties
        public Food Food
        {
            get => _Food;
        }
        public string Name
        {
            get => _Name;
        }
        public string Genus
        {
            get => _Genus;
        }
        public string Gender
        {
            get => _Gender;
        }
        public int Age
        {
            get => _Age;
        }

        //Konstruktor
        public Animals(string name, int age, string genus, string gender, float foodAmount, Food food, int maxHealthRate, int bitePower)
        {
            _Name = name;
            _Genus = genus;
            _Age = age;
            _Gender = gender;
            _FoodAmount = foodAmount;
            _Food = food;
            _MaxHealthRate = maxHealthRate;
            _BitePower = bitePower;
            _FoodList = new List<Food>();
        }

        public void GetAnimalStatistic(Dictionary<Food, float> dict)
        {
            if (dict.ContainsKey(_Food))
            {
                dict[_Food] += _FoodAmount;
            }
            else
            {
                dict[_Food] = _FoodAmount;
            }
        }

        public override string ToString()
        {
            return _Name;
        }



    }
}





