using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week08.Geometry
{
    public class Rectangle : Geometry
    {
        public double _Width;
        public double _Height;
        public Rectangle(double width, double height)
        {
            _Width = width;
            _Height = height;
        }

        public override double getArea()
        {
            return _Width * _Height;
        }
        public override double getCircumference()
        {
            return 2 * (_Width * _Height);
        }
    }
}