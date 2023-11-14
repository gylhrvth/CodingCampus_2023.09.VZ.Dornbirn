using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week06.Zoo3
{
    internal class AnimalFood
    {
        private string _Name;
        private string _Unit;
        private double _PriceperUnit;

        public AnimalFood(string name, string unit, double priceperUnit)
        {
            _Name = name;
            _Unit = unit;
            _PriceperUnit = priceperUnit;
        }
        
        public string Name
        {
            get { return _Name; }
        }
        public string Unit
        { get { return _Unit; } }
        public double PriceperUnit { get { return _PriceperUnit; } }

    }
}
