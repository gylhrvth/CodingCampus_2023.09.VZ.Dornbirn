using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week07.Zoo
{
    internal class Animal
    {
        private string _name;
        private string _gender;
        private Food _food;
        private int _foodrec;
        List<Food> _foodlist;

        public Animal(string gender, string name, Food food, int foodrec)
        {
            _name = name;
            _gender = gender;
            _food = food;
            _foodrec = foodrec;
        }


        public void CalculateFoodReport(Dictionary<Food, int> report)
        {
            if (report.ContainsKey(_food))
            {
                report[_food] += _foodrec;
            }
            else
            {
                report.Add(_food, _foodrec);
            }
        }

        public override string ToString()
        {
            return "Essen: " + _food;
        }

        public void PrintStructure()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|          ├── Rasse: {0, -8}  Name: {1, -8} Essen: {2, -12} Menge: {3}", _gender, _name, _food, _foodrec);
        }
    }
}
