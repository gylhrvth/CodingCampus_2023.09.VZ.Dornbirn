using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week07._05Geometry
{
    public class Rectangle : Geometry
    {
        private double _Length;
        private double _Height;

        public Rectangle(double length, double height)
        {
            _Length = length;
            _Height = height;
        }

        public override double GetCircumference()
        {
            return 2 * _Length + 2 * _Height;
        }

        public override double GetArea()
        {
            return _Length * _Height;
        }
    }
}