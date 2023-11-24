using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week08.Geometry
{
    internal class Square : Geometry
    {
        private double _SideLength;

        public Square(double sideLength)
        {
            _SideLength = sideLength;
        }


        public override double GetCircumference()
        {
            return 4 * _SideLength;
        }


        public override double GetArea()
        {
            return Math.Pow(_SideLength, 2);
        }
    }
}
