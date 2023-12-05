using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Week06.Zoo
{
    internal class Zoo

    {
        private string _Name;
        private string _Place;
        private int _FoundingYear;
        private int _Capacity;
        private List<Enclosure> _EnclosureList;
        public Zoo(string name, string place, int foundingYear, int capacity)
        {
            _Name = name;
            _Place = place;
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

            Console.WriteLine($"├──Zoo: {_Name}, Year: {_FoundingYear}");

            foreach (Enclosure enclosure in _EnclosureList)
            {
                enclosure.PrintZoo();

            }


        }
        public void PrintFoodReport()
        {
            Dictionary<Food, int> report= new Dictionary<Food, int>();

            foreach (Enclosure enc in _EnclosureList)
            {
                enc.ReportFoodRequest(report);
            }

            double sum = 0;
            double sum2 = 0;

            Console.WriteLine("-----------------------------------------------------------------------------");

            Console.WriteLine("Food Report");

            foreach(Food food in report.Keys)
            {
                sum = food.UnitPrice * report[food];
                Console.WriteLine("{0, -9} {1,-20} {2, -10} {3, -10}",
                    food.Name,
                    report[food],
                    food.Unit,
                    food.UnitPrice + "$");
                sum2 += sum;

            }
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("The sum of all the Food expanses is:" +  sum2+"$");
        }
    }

}
