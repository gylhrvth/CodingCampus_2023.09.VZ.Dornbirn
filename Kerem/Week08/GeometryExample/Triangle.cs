using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kerem.Week08;

namespace Kerem.Week08
{
    internal class Triangle : Geometry
    {
        private double _length;

        public Triangle (double length)
        {
            _length = length;
        }
        public override double CircumFerence()   
        {
            return _length + _length + _length;
        }
        public override double GetArea()
        {
            return _length * _length / 2;
        }
        public override string ToString()
        {
            return "Triangle";
        }
    }
}
