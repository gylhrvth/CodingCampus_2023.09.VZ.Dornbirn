using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erik.Week09.Geometry
{
    class Triangle : Geometry
    {
        private double _X;
        private double _Y;
        private double _Z;

        public Triangle(double x, double y, double z)
        {
            _X = x;
            _Y = y;
            _Z = z;
        }

        public override double GetArea()
        {
            double s = (_X + _Y + _Z) / 2;
            double area = Math.Sqrt(s * (s - _X) * (s - _Y) * (s - _Z));
            return area;
        }

        public override double GetCircumference()
        {
            double circumference = _X + _Y + _Z;
            return circumference;
        }
    }
}
