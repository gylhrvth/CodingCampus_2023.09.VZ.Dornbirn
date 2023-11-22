using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week08._02GeometrieInterface
{
    internal class CircleInterface : GeometryInterface
    {
        public double _radius;

        public CircleInterface(double radius)
        {
            _radius = radius;
        }

        public double getCircumference()
        {
            return 2*_radius*double.Pi;
        }

        public double getArea()
        {
            return _radius * _radius * double.Pi;
        }
    }
}
