using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week06.Zoosim
{
    public class Enclosure
    {
        private string _Name;
        private string _Descritpion;
        private string _Climate;
        private List<Animals> _AnimalsList;

        public Enclosure(string name, string descritpion, string climate)
        {
            _Descritpion = descritpion;
            _Name = name;
            _Climate = climate;
            _AnimalsList = new List<Animals>();
        }

        public void AddAnimals(Animals animals)
        {
            if (!_AnimalsList.Contains(animals))
            {
                _AnimalsList.Add(animals);
            }
        }

        public void PrintZoo()
        {
            Console.WriteLine("|   ├── Gehege: {0}, {1}, {2}", _Name, _Descritpion, _Climate);

            foreach (Animals animals in _AnimalsList)
            {
                animals.PrintZoo();
            }
        }

        public void GetFood(Dictionary<Food, double> dic)
        {
            foreach(Animals animals in _AnimalsList)
            {
                animals.GetFood(dic);
            }
            //for(int i = 0; i < _AnimalsList.Count; i++)
            //{
            //    Animals animals = _AnimalsList[i];
            //    animals.GetFood(dic);
            //}
        }

        public void PrintFood()
        {
            Dictionary<Food, double> dic = new Dictionary<Food, double>();
            foreach (Animals animal in _AnimalsList)
            {
                animal.GetFood(dic);
            }
            Console.WriteLine("\nBerechnung der Futterkosten ein Gehege:");
            double cost = 0;

            foreach (Food food in dic.Keys)
            {
                Console.Write("{0} kostet: {1} pro {2}\t\t", food.Name, food.Price, food.Unit);
                double ammount = dic[food];
                double price = food.Price * ammount;
                cost += price;
                Console.WriteLine("Anzahl dieses Futters: {0}", ammount);
            }
            Console.WriteLine("Total Food cost for the Zoo: {0:N2}", cost);
        }
    }
}
