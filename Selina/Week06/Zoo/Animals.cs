using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selina.Week06.Zoo
{
    public class Animals
    {
        private string _Name;
        private int _Age;
        private string _Genus;
        private string _Gender;
        private Food _Food;
        private int _FoodAmount;
        public Dictionary<int, int> _FoodAmountOfAnimal { get; set; }

        public int FoodAmount
        {
            get => _FoodAmount;
            set => _FoodAmount = value;
        }
        public Animals(string name, int age, string gender, Food food, int foodAmount)
        {
            this._Name = name;
            this._Age = age;
            this._Gender = gender;
            this._Food = food;
            this._FoodAmount = foodAmount;
            this._FoodAmountOfAnimal = new Dictionary<int, int>();
        }
 
        public void PrintZoo()
        {
            Console.ForegroundColor= ConsoleColor.DarkCyan;
            Console.WriteLine($"|           |-- {_Name}, {_Food}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
