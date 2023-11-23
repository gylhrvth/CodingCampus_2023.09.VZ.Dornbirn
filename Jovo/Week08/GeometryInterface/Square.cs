using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week08.GeometryInterface
{
    internal class Square : Geometry1
    {
        private double _length;



        public Square(double length)
        {
            _length = length;
        }

        public double GetCircumference()
        {
            return 4 * _length;
        }

        public double GetArea()
        {
            return Math.Pow(_length, 2);
        }
    }
}
