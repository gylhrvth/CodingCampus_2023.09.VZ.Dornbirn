using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week06._05Zoo
{
    internal class Food
    {
        private string _Name;
        private string _Unit;
        private double _PricePerUnit;


        public Food(string name, string unit, double pricePerUnit)
        {
            _Name = name;
            _Unit = unit;
            _PricePerUnit = pricePerUnit;
           
        }


        public string Name
        {
            get => _Name;
            set => _Name = value;
        }


        public string Unit
        {
            get => _Unit;
            set => _Unit = value;
        }

        public double PricePerUnit
        {
            get => _PricePerUnit;
            set => _PricePerUnit = value;
        }


        public override string ToString()
        {
            return "Food: " + _Name + ", Unit: " + _Unit + ", Price: " + _PricePerUnit;
     
        }
    
        
    }
}
