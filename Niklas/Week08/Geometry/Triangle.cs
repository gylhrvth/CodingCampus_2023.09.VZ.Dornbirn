using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week08.Geometry
{
    public class Triangle : Geometry
    {
        public double _Lenght;

        public Triangle(double lenght)
        {
            _Lenght = lenght;
        }

        public override double getArea()
        {
            return Math.Pow(_Lenght, 2) * Math.Sqrt(3) / 4;
            
        }
        public override double getCircumference()
        {
            return _Lenght * 3;
        }
    }
}
