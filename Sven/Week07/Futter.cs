using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sven.Week07
{
    internal class Food
    {

        private string _Name;
        private int _Price;
        private string _Unit;


        public Food(string name, int price, string unit) 
        {
            _Name = name;;
            _Price = price;
            _Unit = unit;

        }

        public override string ToString()
        {
            return $"{_Unit} {_Name}";
        }
    }

}
