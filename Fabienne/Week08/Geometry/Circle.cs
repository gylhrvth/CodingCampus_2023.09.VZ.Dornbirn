using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabienne.Week08.Geometry
{
    public class Circle : Geometry
    {
        private double _Radius;
        public Circle(double radius)
        {
            _Radius = radius;
        }
        public override double GetArea()
        {
            return _Radius * _Radius * Math.PI;
        }
        public override double GetCircumference()
        {
            return 2 * Math.PI * _Radius * 3;
        }
    }
}