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
        private double _amountfood;

        public Animals(string name,int age, string genus, Food food, double amountfood)
        {
            _Name = name;
            _Age = age;
            _Genus = genus;
            _food = food;
            _amountfood = amountfood;
            
        }
        public Food Food
        {
             get => _food; 
        }
        public string Genus
        {
            get => _Genus;
        }
        public string Name
        {
            get => _Name;
        }
        public void GetAnimalStatistic(Dictionary<Food, double> dic)
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
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"│       ├── {_Name}, {_Genus}, {_Age}, eats: {_amountfood} {_food},");
            Console.ForegroundColor = ConsoleColor.White;

        }


    }

}
