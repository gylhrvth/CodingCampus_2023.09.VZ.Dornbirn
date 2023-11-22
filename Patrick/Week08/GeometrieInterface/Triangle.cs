using Patrick.Week08.GeometrieAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.GeometrieInterface
{
    internal class Triangle : IGeometrie
    {
        private double _Length;


        public Triangle(double length) : base()
        {
            _Length = length;
        }


        public double GetArea()
        {
            double a = (_Length * _Length * (Math.Sqrt(3))) / 4;
            return a;
        }

        public double GetCircumference()
        {
            return _Length * 3;
        }
    }
}
