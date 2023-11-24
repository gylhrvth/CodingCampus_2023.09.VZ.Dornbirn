using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week07.GeometryInterface
{
    public class Triangle : Geometry
    {
        public double _Length;

        public Triangle(double length)
        {
            _Length = length;
        }

        public double GetCircumfrence()
        {
            return _Length * 3;
        }

        public double GetArea()
        {
            return Math.Pow(_Length * _Length, 2);
        }



    }
}
