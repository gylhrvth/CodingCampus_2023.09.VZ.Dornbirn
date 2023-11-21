using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week08._01Geometrie
{
    internal class Circle : Geometry
    {

        public Circle(double radius) : base(radius)
        {
            _side = radius;
        }

        public override double getCircumference()
        {
            return 2*_side*double.Pi;
        }

        public override double getArea()
        {
            return _side * _side * double.Pi;
        }
    }
}
