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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("├── Zoo: {0}, founded in {1}", _Name, _Founded);

            Console.ForegroundColor= ConsoleColor.Red;
            foreach (Enclosure enclosure in _Enclosures)
            {
                Console.WriteLine($"│   ├── Enclosure: {enclosure.Name}");
                enclosure.PrintAnimals();
            }

            Console.ForegroundColor = ConsoleColor.White;
        }


    }
}