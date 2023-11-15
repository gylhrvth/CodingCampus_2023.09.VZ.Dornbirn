using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabienne.Week07.Zoo
{
    public class Animals
    {
        private string _Name;
        private string _Gender;
        private Food _Food;
        private int _FoodAmount;

        public Animals(string name, string gender, Food food,int foodA) 
        { 
            _Name = name;
            _Gender = gender;
            _Food = food;
            _FoodAmount = foodA;
        }

        public void PrintAnimals()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("│       ├── {0}, {1}, {2}", _Name, _Gender, _Food);
            Console.ForegroundColor = ConsoleColor.Red; 
       
        }
    }
}
