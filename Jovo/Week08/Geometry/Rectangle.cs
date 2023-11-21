﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week08.Geometry
{
    internal class Rectangle : Geometry1
    {

        private double _length;
        private double _height;

        public Rectangle(double length, double height)
        {
            _length = length;
            _height = height;

        }

        public override double GetCircumference()
        {
            return 2 * _length + 2 * _height;
        }

        public override double GetArea()
        {
            return _length * _height;

        }
    }
}
