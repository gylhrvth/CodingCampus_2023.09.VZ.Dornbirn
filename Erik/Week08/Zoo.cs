using System;
using System.Collections.Generic;


namespace Erik.Week08
{
    public class Zoo
    {
        private string _Name;
        private int _Founded;
        private List<Enclosure> _Enclosure;
        private List<Food> _FoodList;

        public List<Food> foods { get => _FoodList; }

        public List<Enclosure> enclosure { get => _Enclosure; }

        public Zoo(string name, int founded)
        {
            _Name = name;
            _Founded = founded;
            _Enclosure = new List<Enclosure>();
            _FoodList = new List<Food>();
        }

        public void addEncolsureToZoo(Enclosure enclosure)
        {
            _Enclosure.Add(enclosure);
        }

        public void PrintZoo(string prefix)
        {
            Console.WriteLine("{0} Zoo: {1} founded in {2}", prefix, _Name, _Founded);

            foreach (Enclosure enclosure in _Enclosure)
            {
                enclosure.PrintEnclosure("|" + "   " + prefix);
            }
        }
        public void AddFoodList(Food food)
        {
            _FoodList.Add(food);
        }

        public void PrintFoodList()
        {
            Console.WriteLine();
            foreach (Food element in _FoodList)
            {
                Console.WriteLine("Food: {0} / Unit: {1}kg / Price per kg: {2}$", element.foodName, element.unit, element.costPerUnit);
            }
        }

        public void LoopToFeedAnimal()
        {
            foreach(Enclosure enclosure in _Enclosure)
            {
                enclosure.FeedAnimals(this);
            }
            
        }
    }
}
