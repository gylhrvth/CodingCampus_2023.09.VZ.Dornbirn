using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riccardo.Week07.ZooDoppelmayer
{
    internal class Food
    {
        private string _Name;
        private string _Unit;
        private double _Price;


        public Food(string name, string unit, double price)
        {
            _Name = name;
            _Unit = unit;
            _Price = price;
        }


        public override string ToString()
        {
            return $"{_Name}";
        }
    }
}
