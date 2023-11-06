using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week06._04Zoo
{
    public class Futter
    {
        private String _Name;
        private String _Unit;
        private double _PricePerUnit;

        public Futter(string name, string unit, double pricePerUnit)
        {
            _Name = name;
            _Unit = unit;
            _PricePerUnit = pricePerUnit;
        }

        public String Name 
        { 
            get { return _Name; }
            set { _Name = value; }
        }
        public String Unit
        {
            get { return _Unit; }
            set { _Unit = value; }
        }
        public double PricePerUnit
        {
            get { return _PricePerUnit; }
            set { _PricePerUnit = value; }
        }

        public void PrintFood(int _FoodCount)
        {
            Console.WriteLine("│\t\t\t├── {0}, {1} {2}", _Name, _FoodCount, _Unit);
        }
    }
}
