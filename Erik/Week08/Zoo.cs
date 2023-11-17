using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection.PortableExecutable;
using System.Runtime.Serialization.Formatters;

namespace Erik.Week08
{
    public class Zoo
    {
        private string _Name;
        private int _Founded;
        private List<Enclosure> _Enclosure;
        private List<Food> _FoodList;
        private List<Keeper> _KeeperList;


        public List<Keeper> keeperList { get => _KeeperList; }

        public Zoo(string name, int founded, int days)
        {
            _Name = name;
            _Founded = founded;
            _Enclosure = new List<Enclosure>();
            _FoodList = new List<Food>();
            _KeeperList = new List<Keeper>();
        }
        
        public void add(Enclosure enclosure)
        {
            _Enclosure.Add(enclosure);
        }

        public void add(Keeper keeper)
        {
            _KeeperList.Add(keeper);
        }

        public void PrintZoo(string prefix)
        {
            Console.WriteLine("{0} Zoo: {1} founded in {2}", prefix, _Name, _Founded);

            foreach (Enclosure enclosure in _Enclosure)
            {
                enclosure.PrintEnclosure("|" + "   " + prefix);
            }
        }
        public void simulateDay(int day)
        {
            for (int i = 0; i < day; i++)
            {
                switch (i % 7)
                {
                    case 1:
                        Console.WriteLine("Monday:\n ");                        
                        break;
                    case 2:
                        Console.WriteLine("Tuesday:\n ");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday:\n ");
                        break;
                    case 4:
                        Console.WriteLine("Thursday:\n ");
                        break;
                    case 5:
                        Console.WriteLine("Friday:\n ");
                        break;
                    case 6:
                        Console.WriteLine("Saturday:\n ");
                        break;
                    case 0:
                        Console.WriteLine("Sunday:\n ");
                        break;
                }
                
                foreach (Keeper keeper in _KeeperList)
                {
                    keeper.FeedEnclosures();
                }
                Console.WriteLine();

            }
        }

        public void AddFoodList(Food food)
        {
            _FoodList.Add(food);
        }

        public void PrintFoodList()
        {
            int unitResault = 0;
            int totalCost = 0;
            int totalWeight = 0;

            foreach (Food element in _FoodList)
            {
                Console.WriteLine("Food: {0} / Unit: {1}kg / Price per kg: {2}$", element.foodName, element.unit, element.costPerUnit);
                unitResault += element.unit;
            }
            foreach (Enclosure enc in _Enclosure)
            {
                totalCost += enc.calculateCost();
                totalWeight += enc.calculateConsumedFood();
            }

            Console.WriteLine($"\nDaily consumption: {totalWeight}kg / Daily food costs: {totalCost}$");
        }


    }
}
