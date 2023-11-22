using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riccardo.Week08
{
    public class Circle : Geometry
    {
        private double _radius;
        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double GetCircumfence()
        {
            return Math.PI * _radius * 2;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
