using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Week08.Geometry
{
   public class Circle: Geo
    {
        private double _radius;

        public Circle(double lenght)
        {
            _radius = lenght;
        }
        public override double GetCircumference()
        {
            return 2 * _radius + Math.PI;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
