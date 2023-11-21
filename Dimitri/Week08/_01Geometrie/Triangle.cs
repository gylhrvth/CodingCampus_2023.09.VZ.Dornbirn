using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week08._01Geometrie
{
    internal class Triangle : Geometry
    {

        public Triangle(double length) : base(length)
        {
            _side = length;
        }

        public override double getCircumference()
        {
            return 3 * _side;
        }

        public override double getArea() 
        {       
            return (double)1 / 4 * _side * _side * Math.Sqrt(3);
        }

    }
}
