using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week07.Geometry
{
    public class Circle : Geometry
    {
        public double _Radius;
        public double _Pi;

        public Circle(double radius)
        {
            _Radius = radius;
            _Pi = Math.PI;
        }

        public override double getCircumfrence()
        {
            return 2 * _Pi * _Radius;
        }

        public override double getArea()
        {
            return Math.Pow(_Radius, 2) * _Pi;
        }

    }
}
