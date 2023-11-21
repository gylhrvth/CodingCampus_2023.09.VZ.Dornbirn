using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week08._02GeometrieInterface
{
    internal class RectangleInterface : GeometryInterface
    {
        public double _width;
        public double _height;

        public RectangleInterface(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public double getArea()
        {
            return (_width * _height);
        }

        public double getCircumference()
        {
            return ((2*_height) + (2 * _width));
        }
    }
}
