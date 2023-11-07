using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week06.Zoosim
{
    public class Zoo
    {
        private string _Name;
        private int _FoundingYear;
        private List<Enclosure> _Enclosure;
        private string _Locality;
        private int _Capacity;

        public Zoo(string name, int foundingyear, string locality, int capacity)
        {
            _Locality = locality;
            _Capacity = capacity;
            _Name = name;
            _FoundingYear = foundingyear;
            _Enclosure = new List<Enclosure>();
        }

        public void AddEnclosure(Enclosure enclosure)
        {
            if (!_Enclosure.Contains(enclosure))
            {
                _Enclosure.Add(enclosure);
            }
        }

        public void PrintZoo()
        {
            Console.WriteLine("├── Zoo: {0} {1}", _Name, _FoundingYear);

            foreach (Enclosure enclosure in _Enclosure)
            {
                enclosure.PrintZoo();
            }
        }

        // größtes problem wohin mit welcher funktion bzw wieso??
        public void PrintZooFood()
        {
            Dictionary<Food, double> dic = new Dictionary<Food, double>();
            foreach (var enclosure in dic.Keys)
            {
                enclosure.EnclosureStats(dic);
            }
            Console.WriteLine("Food per?");
            double foodcost = 0;
            foreach (Food food in dic.Values)
            {
                Console.WriteLine();
                double ammount = dic[food];
                double price = food.PricePerUnit * ammount;
                foodcost += price;
            }
        }



    }
}
