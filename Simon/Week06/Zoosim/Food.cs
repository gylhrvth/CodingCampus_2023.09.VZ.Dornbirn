﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week06.Zoosim
{
    public class Food
    {
        private string _Name;
        private string _Unit;
        private double _Price;

        public string Name
        {
            get => _Name;
        }
        public string Unit
        {
            get => _Unit;
        }
        public double Price
        {
            get => _Price;
        }

        public Food(string name, string unit, double price)
        {
            _Name = name;
            _Unit = unit;
            _Price = price;
        }

        //public string Name { get { return _Name; } }
        public override string ToString()
        {
            return _Name;
        }

        


    }
}
