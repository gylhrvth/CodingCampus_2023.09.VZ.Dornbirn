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
        private List<Caretaker> _Caretaker;
        ConsoleColor[] colorList = new ConsoleColor[]
        {
            ConsoleColor.Red, ConsoleColor.Blue, ConsoleColor.DarkYellow, ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.DarkRed, ConsoleColor.White, ConsoleColor.DarkBlue, ConsoleColor.Yellow, ConsoleColor.DarkGray, ConsoleColor.DarkGreen, ConsoleColor.DarkRed
        };
        public Zoo(string name, int founded) 
        {
            _Name = name;
            _Founded = founded;
            _Enclosures = new List<Enclosure>();
            _Caretaker = new List<Caretaker>();
        }
        public void addEnclosure(Enclosure enclosure)
        {
            _Enclosures.Add(enclosure);
        }
        public void AddCaretaker(Caretaker caretaker)
        {
            _Caretaker.Add(caretaker);
        }
        public void PrintStructure()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("├── Continent: {0}, founded in {1}", _Name, _Founded);
                        
            for (int i = 0; i < _Enclosures.Count; i++) 
            {

                Console.ForegroundColor = colorList[i % colorList.Length];

                Enclosure enclosure = _Enclosures[i];
                Caretaker caretaker = _Caretaker[i];

                Console.WriteLine($"│    ├── Protector: {caretaker.Name}");
                Console.WriteLine($"│          ├── Country: {enclosure.Name}");

                Console.ForegroundColor = colorList[i % colorList.Length];
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
            double sum = 0;
            double sum2 = 0;

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Food request report:");
            foreach (Food f in report.Keys)
            {
                sum = f.Unitprice * report[f];
                Console.WriteLine("{0, -20} {1, 5} {2, -5} {3, -10}",
                    f.Name,
                    report[f],
                    f.Unit,
                    f.Unitprice + " €"
                    ) ;

                sum2 += sum;
            }
            Console.WriteLine("----------------------------------------------");
            Console.Write("The sum is:                      ");
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine(+sum2 + " €");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}