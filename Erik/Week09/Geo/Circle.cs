using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erik.Week09.Geo
{
    public class Circle : Geometry
    {
        private double _Radius;

        public Circle(double radius)
        {
            _Radius = radius;
        }

        public override double GetCircumference()
        {
            double circumference = 2 * _Radius * Math.PI;
            return circumference;
        }

        public override double GetArea()
        {
            double area = _Radius * _Radius * Math.PI;
            return area;
        }
    }
}
