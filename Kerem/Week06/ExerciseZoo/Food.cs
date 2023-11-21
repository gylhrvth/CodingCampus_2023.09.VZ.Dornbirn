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
        private double _priceperunit;

        public double PricePerUnit
        {
            get => _priceperunit;

        } 



        public Food(string name, string unit, double priceperunit)
        {
            _name = name;
            _unit = unit;
            _priceperunit = priceperunit;
        }      
        public override string ToString()
        {
            return _name + ",  Unit: " + _unit + ", Price: " + _priceperunit;
        }

    }

}
