using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week08.Geometry
{
    internal class Square : Geometry1
    {
        private double _length;



        public Square(double length)
        {
            _length = length;
        }

        public override double GetCircumference()
        {
            return 4 * _length;
        }

        public override double GetArea()
        {
            return Math.Pow(_length, 2);
        }
    }
}
