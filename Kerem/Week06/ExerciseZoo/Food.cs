using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Kerem.Week06.ExerciseZoo
{
    internal class Food
    {
        private string _name;
        private string _unit;
        private double _price;


        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string Unit
        {
            get => _unit;
            set => _unit = value;
        }
        public double PricePerUnit
        {
            get => _price;
            set => _price = value;
        }

        public Food(string name, string unit, double price)
        {
            _name = name;
            _price = price;
            _unit = unit;
        }      
        public override string ToString()
        {
            return _name + ",  Unit: " + _unit + ", Price: " + _price;
        }

    }

}
