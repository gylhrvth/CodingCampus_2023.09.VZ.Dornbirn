using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week06.Zoosim
{
    internal class Animals
    {
        private string _Name;
        private int _Age;
        private string _Species;
        private string _Gender;        
        private Food _Food;
        private int _FoodAmount;

        public Animals(string name, int age, string species, string gender, Food food, int ammount)
        {
            _Name = name;
            _Age = age;
            _Species = species;
            _Gender = gender;
            _Food = food;
            _FoodAmount = ammount;            
        }

       public void PrintZoo()
        {
            Console.WriteLine(" ---> ---> {0} {1} {2} {3} eats: {4} {5}", _Name, _Age, _Species, _Gender, _FoodAmount, _Food);
        }



    }
}
