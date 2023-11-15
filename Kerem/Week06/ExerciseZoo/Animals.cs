using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week06.ExerciseZoo
{
    internal class Animals
    {
        private string _Name;
        private string _Genus;
        private int _Age;
        private Food _food;
        private int _amountfood;

        public Animals(string name,int age, string genus, Food food, int amountfood)
        {
            _Name = name;
            _Age = age;
            _Genus = genus;
            _food = food;
            _amountfood = amountfood;
            
        }
        public void GetAnimalStatistic(Dictionary<Food, float> dic)
        {
            if (dic.ContainsKey(_food))
            {
                dic[_food] += _amountfood;
            }
            else
            {
                dic[_food] = _amountfood;
            }
        }

        public void PrintZoo()
        {
            Console.WriteLine($"│       ├── {_Name}, {_Genus}, {_Age}, eats: {_amountfood} {_food},");
        }
    }
    
}
