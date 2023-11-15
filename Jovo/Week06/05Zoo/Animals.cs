using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week06._05Zoo
{
    internal class Animals
    {
        private string _Name;
        private int _Age;
        private string _Genus;
        private string _Gender;
        private Food _Food;
        private int _FoodCount;


        public Animals(string name, int age, string genus, string gender, Food food, int foodCount)
        {
            _Name = name;
            _Age = age;
            _Genus = genus;
            _Gender = gender;
            _Food = food;
            _FoodCount = foodCount;
        }

        public string Name
        {
            get => _Name;
            set => _Name = value;
        }


        public void PrintZoo()
        {
            Console.WriteLine($"│   │   ├── {_Name}, {_Age}, {_Gender}, {_Genus}, eats : {_Food.Name}");
        }

        public void GetAnimalStatistic(Dictionary<Food, float> dic)
        {
            if (dic.ContainsKey(_Food))
            {
                dic[_Food] += _FoodCount;
            }
            else
            {
                dic[_Food] = _FoodCount;
            }
        }


        public string ToString()
        {
            return 
        }
    }
    
}
