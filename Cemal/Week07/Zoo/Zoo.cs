using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week07.Zoo
{
    internal class Zoo
    {
        private string _name;
        private int _foundingYear;
        private List<Enclosure> _enclosures;
        private List<Food> _food;

        public Zoo(string name, int foundingYear)
        {
            _name = name;
            _foundingYear = foundingYear;
            _enclosures = new List<Enclosure>();
            _food = new List<Food>();
        }

        public void addEnclosure(Enclosure enc)
        {
            _enclosures.Add(enc);
        }

        public void addFood(Food food)
        {
            _food.Add(food);
        }


        public override string ToString()
        {
            return "Zoo: " + _name + ", founded: " + _foundingYear;
        }

        public void PrintStructure()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("├── Zoo: {0}, founded: {1}", _name, _foundingYear);
            Console.WriteLine();

            foreach (Enclosure enc in _enclosures)
            {
                enc.PrintStructure();
                Console.WriteLine();
                Console.WriteLine();
            }

            foreach (Food food in _food)
            {
                food.PrintStructure();
            }
        }


        public void CalculateFoodReport()
        {
            int totalprice = 0;
            Dictionary<Food, int> report = new Dictionary<Food, int>();
            foreach (Enclosure enc in _enclosures)
            {
                enc.CalculateFoodReport(report);
            }


            foreach (Food f in report.Keys)
            {
                int foodAmount = report[f];
                int price = foodAmount * f.Price;
                totalprice += price;

                Console.WriteLine();
                Console.WriteLine("{0, -20} |Gesamtmenge: {1, 2} {2, -10} Einzelpreis: {3, 3} Euro|", f.Name, report[f], f.Unit, price);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0, 78}", ZooMain.UNDERLINE + "Gesamtpreis: " +totalprice + " Euro" + ZooMain.RESET);
        }
    }
}
