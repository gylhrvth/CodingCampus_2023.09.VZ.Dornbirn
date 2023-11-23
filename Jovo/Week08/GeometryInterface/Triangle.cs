using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week08.GeometryInterface
{
    internal class Triangle : Geometry1
    {
        private double _length;
        public Triangle(double length)
        {
            _length = length;
        }


        public double getCircumference()
        {
            return 3 * _length;

        }

        public double getArea()
        {


            return _length * _length * Math.Sqrt(3) / 4;
        }
    }
}
