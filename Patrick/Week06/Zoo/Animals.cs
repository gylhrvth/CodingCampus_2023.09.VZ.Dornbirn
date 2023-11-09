using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week06.Zoo
{
    internal class Animals
    {
        private string _Name;
        private string _Genus;
        private string _Age;
        private float _HowManyFood;
        private Food _Food;
        private List<Food> _FoodList;

        //properties
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

        public string Age
        {
            get => _Age;
            set => _Age = value;
        }
        public float HowManyFood
        {
            get => _HowManyFood;
            set => _HowManyFood = value;
        }

        public Food Food
        {
            get => _Food;
            set => _Food = value;
        }

        public List<Food> FoodList
        {
            get => _FoodList;
            set => _FoodList = value;
        }

        //Konstruktor
        public Animals(string name, string genus, string age, float howManyFood, Food food)
        {
            _Name = name;
            _Genus = genus;
            _Age = age;
            _HowManyFood= howManyFood;
            _Food = food;
            _FoodList = new List<Food>();
        }

        public void GetAnimalStatistic(Dictionary<Food, float> dic)
        {
            if (dic.ContainsKey(_Food))
            {
                dic[_Food] += _HowManyFood;
            }
            else
            {
                dic[_Food] = _HowManyFood;
            }
        }

        public override string ToString()
        {
            return Food._Name;
        }

    }
}
