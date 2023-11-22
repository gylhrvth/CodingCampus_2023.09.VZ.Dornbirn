using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week08.Geometry
{
    public class Circle : Geometry
    {
        public double _Radius;

        public Circle(double radius)
        {
            _Radius = radius;
        }

        public override double getArea()
        {
            return _Radius * 2 * Math.PI;
        }
        public override double getCircumference()
        {
            return 2 * _Radius * Math.PI;
        }
    }
}
