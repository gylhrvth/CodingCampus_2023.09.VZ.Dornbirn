using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabienne.Week07.Zoo
{
    public class Animal
    {
        private string _Name;
        private string _Gender;
        private Food _Food;
        private int _FoodAmount;

        public Animal(string name, string gender, Food food, int foodA) 
        { 
            _Name = name;
            _Gender = gender;
            _Food = food;
            _FoodAmount = foodA;            
        }

        public void PrintAnimals()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("│       ├── {0}, {1}, {2}, {3}", _Name, _Gender, _Food, _FoodAmount);
            Console.ForegroundColor = ConsoleColor.Red;        
        }

        public void ReportFoodRequest(Dictionary<Food, double> report) 
        {
            if (report.ContainsKey(_Food))
            {
                report[_Food] += _FoodAmount;
            }
            else
            {
                report.Add(_Food, _FoodAmount);
            }
        }
    }
}
