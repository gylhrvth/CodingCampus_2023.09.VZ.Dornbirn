using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week07.Zoo
{
    internal class Food
    {
        private string _name;
        private string _unit;
        private int _price;

        public string Name { get => _name; }
        public string Unit { get => _unit; }

        public Food(string name, string unit, int price) 
        {
            _name = name;
            _unit = unit;
            _price = price;
        }

        public override string ToString()
        {
            return _name;
        }

        public void PrintStructure()
        {
            Console.WriteLine("|        ├── Essen: {0}, Preis: {1} {2}", _name, _price, _unit);
        }
    }
}
