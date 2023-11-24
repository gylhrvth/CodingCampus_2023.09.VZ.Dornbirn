using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week08.AbstraktGeometry
{
    public class Triangle : Geometry
    {
        private double _lenght;

        public Triangle(double a)
        {
            _lenght = a;

        }

        public override double getArea()
        {
            return _lenght * _lenght + Math.Sqrt(3) / 4;
        }

        public override double getCircumference()
        {
            return _lenght * 3;
        }
    }
}
