using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mehmet.ZOO
{
    internal class Animal
    {
        private string _Race;
        private string _Name;
        private List<Food> _FoodList;


        public Animal(string race, string name)
        {
            _Race = race;
            _Name = name;
            _FoodList = new List<Food>();
        }
        public void AddFood(Food food)
        {
            _FoodList.Add(food);
        }



        public void PrintStrukture()
        {
            Console.WriteLine("      └──┬┤ Tier: {0}, Rasse: {1}",
                _Name,
                _Race);
            foreach (Food food in _FoodList)
            {
                food.PrintStrukture();
            }
        }


    }
}
