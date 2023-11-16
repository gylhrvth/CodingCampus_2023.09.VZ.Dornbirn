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
        public int Price
        {
            get => _price; set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be lower than 0");
                }
                _price = value;
            }
        }


        //public int GetPrice() { return _price; }

        //public void SetPrice(int price) { 
        //    if(price < 0)
        //    {
        //        throw new ArgumentOutOfRangeException("Price cannot be lower than 0");
        //    }
        //    _price = price; 
        //}

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
            Console.WriteLine("{0,-20} Preis: {1, 5} Euro pro {2}", _name, _price, _unit);
        }
    }
}
