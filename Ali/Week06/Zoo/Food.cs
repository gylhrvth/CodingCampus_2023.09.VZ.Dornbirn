﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Week06.Zoo
{
    internal class Food
    {
        private string _Name;
        private string _Unit;
        private double _Price;
        private double _UnitPrice;

        public string Name { get  => _Name; }
        public string Unit { get => _Unit; }
        
        public double UnitPrice { get => _UnitPrice; }



        public Food(string name, string unit, double unitprice)
        {
            _Name = name;
            _Unit = unit;
           
            _UnitPrice = unitprice;
        }


        public override string ToString()
        {
            return $"{_Name}";
        }
    }
}
