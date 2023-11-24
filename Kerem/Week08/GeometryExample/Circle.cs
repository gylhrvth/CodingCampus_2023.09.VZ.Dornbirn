using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week08
{
    internal class Circle  : Geometry
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }
        public override double CircumFerence()
        {
            return Math.PI * 2 * _radius;
        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(_radius,2);
        }

        public override string ToString()
        {
            return "Circle";
        }
    }
}
