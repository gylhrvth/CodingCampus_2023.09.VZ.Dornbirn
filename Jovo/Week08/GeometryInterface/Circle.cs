using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week08.GeometryInterface
{
    public class Circle : Geometry1
    {
        private double _radius;


        public Circle(double length)
        {
            _radius = length;
        }

        public double getCircumference()
        {
            return 2 * _radius + Math.PI;
        }

        public double getArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
