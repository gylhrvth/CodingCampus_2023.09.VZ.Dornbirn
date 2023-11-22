using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.GeometrieAbstract
{
    internal class Triangle : Geometrie
    {
        private double _Length;


        public Triangle(double length) : base()
        {
            _Length = length;
        }


        public override double GetArea()
        {
            double a = (_Length * _Length * (Math.Sqrt(3))) / 4;
            return a;
        }

        public override double GetCircumference()
        {
            return _Length * 3;
        }
    }
}
