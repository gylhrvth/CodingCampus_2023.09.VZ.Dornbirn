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
        private bool _IsHungry;
        private int _Life;
        private List<Animal> _AnimalsList;

        public bool IsHungry { get => _IsHungry; set => _IsHungry = value; }
        public Food Food { get => _Food; }
        public string AnimalName { get => _AnimalName; }

        public int Hunger { get => _Life; set => _Life = value; }

        public Animal(string animalName, string genus, string gender, Food food, int life, int foodNeed)
        {
            _IsHungry = true;
            _AnimalName = animalName;
            _Genus = genus;
            _Gender = gender;
            _Food = food;
            _Life = life;
            _FoodNeed = foodNeed;
            _AnimalsList = new List<Animal>();
        }


        public void PrintAnimal(string prefix)
        {
            Console.WriteLine("{0} {1}, {2}, {3} , {4} , {5} Life", prefix, _AnimalName, _Genus, _Gender, _Food.foodName, _Life);
        }


        public int returnFoodCost()
        {
            return _Food.costPerUnit * _FoodNeed;
        }
        public int returnConsumedFood()
        {
            return _FoodNeed;
        }


    }
}
