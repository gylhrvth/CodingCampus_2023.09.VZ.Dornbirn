using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sven.Week07
{
    internal class Animal
    {

        private string _Name;
        private string _Species;
        private string _Gender;
        private int _Age;
        private Food _Food;
        private int _FoodAmount;


        public Animal(string name, int age, string species, string gender, Food food, int foodAmount)
        {
            _Name = name;
            _Age = age;
            _Species = species;
            _Gender = gender;
            _Food = food;
            _FoodAmount = foodAmount;

        }

        public void GetAnimalStatistic(Dictionary<Food, float> dic)
        {
            if (dic.ContainsKey(_Food))
            {
                dic[_Food] += _FoodAmount;
            }
            else
            {
                dic[_Food] = _FoodAmount;
            }
        }

        public void PrintZoo()
        {
            Console.WriteLine($"│       ├── {_Name}, {_Age}, {_Gender}, {_Species}, Food Required : {_FoodAmount} {_Food}: Price per day:");
        }


    }
}
