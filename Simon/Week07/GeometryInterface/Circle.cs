using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week07.GeometryInterface
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

        public double GetCircumfrence()
        {
            return 2 * _Pi * _Radius;
        }

        public double GetArea()
        {
            return Math.Pow(_Radius, 2) * _Pi;
        }

    }
}
