using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabienne.Week07.Zoo
{
    public  class Zoo
    {
        private string _Name;
        private int _Founded;
        private List<Enclosure> _Enclosures;
        ConsoleColor[] colorList = new ConsoleColor[]
        {
            ConsoleColor.Red, ConsoleColor.Blue, ConsoleColor.DarkYellow, ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.DarkRed, ConsoleColor.White, ConsoleColor.DarkBlue, ConsoleColor.Yellow, ConsoleColor.DarkGray, ConsoleColor.DarkGreen, ConsoleColor.DarkRed
        };
        ConsoleColor[] colorList2 = new ConsoleColor[]
        {
            ConsoleColor.Red, ConsoleColor.Blue, ConsoleColor.DarkYellow, ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.DarkRed, ConsoleColor.White, ConsoleColor.DarkBlue, ConsoleColor.Yellow, ConsoleColor.DarkGray, ConsoleColor.DarkGreen, ConsoleColor.DarkRed
        };

        public Zoo(string name, int founded) 
        {
            _Name = name;
            _Founded = founded;
            _Enclosures = new List<Enclosure>();
        }
        public void addEnclosure(Enclosure enclosure)
        {
            _Enclosures.Add(enclosure);
        }
        public void PrintStructure()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("├── Zoo: {0}, founded in {1}", _Name, _Founded);

                        
            for (int i = 0; i < _Enclosures.Count; i++) 
            {
                Console.ForegroundColor = colorList[i % colorList.Length];
                Enclosure enclosure = _Enclosures[i];
                Console.WriteLine($"│   ├── Enclosure: {enclosure.Name}");
                Console.ForegroundColor = colorList2[i % colorList2.Length];
                enclosure.PrintAnimals();
            }

            Console.ForegroundColor = ConsoleColor.White;
        }


        public void PrintFoodReport()
        {
            Dictionary<Food, double> report = new Dictionary<Food, double>();
            foreach (Enclosure enc in _Enclosures)
            {
                enc.ReportFoodRequest(report);
            }

            Console.WriteLine("Food request report");
            foreach (Food f in report.Keys)
            {
                Console.WriteLine("{0, -20} {1, 5} {2, -5}", 
                    f.Name,
                    report[f],
                    f.Unit
                    );
            }
        }

    }
}