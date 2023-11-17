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
        private Food _Food;
        private List<Food> _FoodList;

        //Properties
        public string Name
        {
            get => _Name;
            set => _Name = value;
        }
        public string Genus
        {
            get => _Genus;
            set => _Genus = value;
        }
        public int Age
        {
            get => _Age;
            set => _Age = value;
        }
        public string Gender
        {
            get => _Gender;
            set => _Gender = value;
        }
        public float FoodAmount
        {
            get => _FoodAmount;
            set => _FoodAmount = value;
        }
        public Food Food
        {
            get => _Food;

        }
        public List<Food> FoodList
        {
            get => _FoodList;
            set => _FoodList = value;
        }


        //Konstruktor
        public Animals(string name, int age, string genus, string gender, float foodAmount, Food food)
        {
            _Name = name;
            _Genus = genus;
            _Age = age;
            _Gender = gender;
            _FoodAmount = foodAmount;
            _Food = food;
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





