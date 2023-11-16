using System;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace Erik.Week08
{
    public class Animal
    {
        private string _AnimalName;
        private string _Genus;
        private string _Gender;
        private Food _Food;
        private int _FoodNeed;
        private int _Life;
        public Food food { get => _Food;  }
    
        public int hunger { get => _Life; set => _Life = value; }

        public Animal(string animalName, string genus, string gender, Food food, int life, int foodNeed)
        {
            _AnimalName = animalName;
            _Genus = genus;
            _Gender = gender;
            _Food = food;
            _Life = life;
            _FoodNeed = foodNeed;
        }
      

        public void PrintAnimal(string prefix)
        {
            Console.WriteLine("{0} {1}, {2}, {3} , {4} , {5} Life", prefix, _AnimalName, _Genus, _Gender, _Food.foodName, _Life);
        }

        public int returnFoodCost()
        {
            return food.costPerUnit * _FoodNeed;
        }
        public int retrunConsumedFood()
        {
            return _FoodNeed;
        }
    }
}
