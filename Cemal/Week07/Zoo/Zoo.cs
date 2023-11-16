using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week07.Zoo
{
    internal class Zoo
    {
        private string _name;
        private int _foundingYear;
        private List<Enclosure> _enclosures;
        private int totalprice = 0;

        public Zoo(string name, int foundingYear)
        {
            _name = name;
            _foundingYear = foundingYear;
            _enclosures = new List<Enclosure>();
        }

        public void addEnclosure(Enclosure enc)
        {
            _enclosures.Add(enc);
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
            }
        }


        public void CalculateFoodReport()
        {
            Dictionary<Food, int> report = new Dictionary<Food, int>();
            foreach (Enclosure enc in _enclosures)
            {
                enc.CalculateFoodReport(report);
            }

            foreach (Food f in report.Keys)
            {
                Console.WriteLine("{0, -20} {1, 10} {2, -5}",
                    f.Name,
                    report[f],
                    f.Unit
                    );
            }
        }
    }
}
