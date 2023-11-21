using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week08
{
    internal class Triangle : Geometry
    {
        private double _length;
        private double _height;

        public Triangle (double length, double height)
        {
            _length = length;
            _height = height;
        }
        public override double CircumFerence()
        {
            return _length + _length + _length;
        }
        public override double GetArea()
        {
            return _length * _height /2;
        }
    }
}
