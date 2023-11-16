using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sven.Week07
{
    internal class Zoo
    {

        private string _Name;
        private string _Location;
        private int _FoundingYear;
        private List<Enclosure> _EnclosureList;

        public Zoo(string name, string location, int foundingyear)
        {

            _Name = name;
            _Location = location;
            _FoundingYear = foundingyear;
            _EnclosureList = new List<Enclosure>();

        }

        public void AddEnclosure(Enclosure enclosure)
        {

            if (!_EnclosureList.Contains(enclosure))
            {
                _EnclosureList.Add(enclosure);
            }
        }

        public void PrintZoo()
        {

            Console.WriteLine($"Zoo: {_Name}, Location: {_Location}, Founding Year: {_FoundingYear}");

            foreach (Enclosure enclosure in _EnclosureList)
            {
                enclosure.PrintZoo();

            }


        }

        public void PrintFoodStatistic()
        {
            Dictionary<Food, double> dic = new Dictionary<Food, double>();
            foreach (var enclosure in _EnclosureList)
            {
                enclosure.GetEnclosureStatistic(dic);
            }
            Console.WriteLine("Food requirements:");
            double cost = 0;
            foreach (Food food in dic.Keys)
            {
                Console.WriteLine($"{food.Name} : {dic[food]} {food.Unit} /cost per Unit: {food.PricePerUnit}€ ");
                double amount = dic[food];
                double price = food.PricePerUnit * amount;
                cost += price;
            }
            Console.WriteLine("total daily cost of food: {0:N2}€", cost);
        }


    }
}
