using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kerem.Week08;

namespace Kerem.Week08
{
    internal class Rectangle  : Geometry
    {
        private double _length;
        private double _width;

        public Rectangle(double length, double width)
        {
            _length = length;
            _width = width;
        }
        public override double CircumFerence()
        {
            return 2 * (_length) + 2 * (_width);
        }

        public override double GetArea()
        {
            return _length * _width;
        }
        public override string ToString()
        {
            return "Rectangle";
        }
    }

}
