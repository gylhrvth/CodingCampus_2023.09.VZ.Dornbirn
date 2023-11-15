using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Jovo.Week06._05Zoo
{
    internal class Zoo
    {
        private string _Name;
        private string _Locality;
        private int _FoundingYear;
        private int _Capacity;
        private List<Enclosure> _EnclosureList;

        public Zoo(string name, string locality, int foundingYear, int capacity)
        {
            _Name = name;
            _Locality = locality;
            _FoundingYear = foundingYear;
            _Capacity = capacity;
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

            Console.WriteLine($"Zoo: {_Name}, Location: {_Locality}, Founding Year: {_FoundingYear}, Capacity Enclosures: {_Capacity} ");

            foreach (Enclosure enclosure in _EnclosureList)
            {
                enclosure.PrintZoo();

            }


        }

        public void PrintZooStatistic()
        {
            Dictionary<Food,double> dic = new Dictionary<Food,double>();
            foreach(var enclosure in _EnclosureList )
            {
                enclosure.GetEnclosureStatistic(dic);
            }
            Console.WriteLine("Food requirements:");
            double cost = 0;
            foreach (Food food in dic.Keys)
            {
                Console.WriteLine($"{food.Name} : {dic[food]} {food.Unit} /cost per Unit: {food.PricePerUnit}Euro ");
                double amount = dic[food];
                double price = food.PricePerUnit * amount;
                cost += price;
            }
            Console.WriteLine("total daily cost for food: {0:N2}Euro", cost);
        }
      
        
    }



}
