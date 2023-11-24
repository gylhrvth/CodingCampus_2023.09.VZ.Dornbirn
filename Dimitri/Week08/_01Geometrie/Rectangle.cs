using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week08._01Geometrie
{
    internal class Rectangle : Geometry
    {
        public double _width;

        public Rectangle(double height, double width) : base(height)
        {
            _side = height;
            _width = width;
        }

        public override double getArea()
        {
            return (_width * _side);
        }

        public override double getCircumference()
        {
            return ((2 * _side) + (2 * _width));
        }
    }
}
