using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week08._02GeometrieInterface
{
    internal class TriangleInterface : GeometryInterface
    {
        public double _length;

        public TriangleInterface(double length)
        {
            _length = length;
        }

        public double getCircumference()
        {
            return 3 * _length;
        }

        public double getArea() 
        {       
            return (double)1 / 4 * _length * _length * Math.Sqrt(3);
        }

    }
}
