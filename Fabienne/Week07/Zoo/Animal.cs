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
        private string _Species;
        private Food _Food;
        private double _FoodAmount;
        private double _FoodPrice;
        ConsoleColor[] colorList2 = new ConsoleColor[]
        {
            ConsoleColor.Red, ConsoleColor.Blue, ConsoleColor.DarkYellow, ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.DarkRed, ConsoleColor.White, ConsoleColor.DarkBlue, ConsoleColor.Yellow, ConsoleColor.DarkGray, ConsoleColor.DarkGreen, ConsoleColor.DarkRed
        };

        public Animal(string name, string gender, string species, Food food, double foodA) 
        { 
            _Name = name;
            _Gender = gender;
            _Species = species;
            _Food = food;
            _FoodAmount = foodA; 
        }

        public void PrintAnimals()
        {

            Console.WriteLine("│              ├── {0}, {1}, {2}, {3}, {4}", _Name, _Gender, _Species, _Food, _FoodAmount) ;
                  
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
