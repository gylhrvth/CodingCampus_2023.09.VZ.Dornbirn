using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erik.Week09.Geometry
{
    public class Rectangle : Geometry
    {
        private double _X;
        private double _Y;

        public Rectangle(double x, double y)
        {
            _X = x;
            _Y = y;
        }

        public override double GetArea()
        {
            double area = _X * _Y;
            return area;
        }
        
        public override double GetCircumference()
        {
            double circumference = 2 * _X * (2 * _Y);
            return circumference;
        }
    }
}
