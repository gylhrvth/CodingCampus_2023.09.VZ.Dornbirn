using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week08.Geometry
{
    internal class Triangle : Geometry
    {
        private double _Side1;
        private double _Side2;
        private double _Side3;


        public Triangle(double side1, double side2, double side3)
        {
            double maxSide = Math.Max(side3, Math.Max(side1, side2));

            if (!(maxSide == side3 && side3 < side2 + side1   ||
                  maxSide == side1 && side1 < side3 + side2   ||
                  maxSide == side2 && side2 < side1 + side3))
            {
                throw new ArgumentOutOfRangeException();
            }

            _Side1 = side1;
            _Side2 = side2;
            _Side3 = side3;
        }


        public override double GetCircumference()
        {
            return _Side1 + _Side2 + _Side3;
        }


        public override double GetArea()
        {
            double s = GetCircumference() / 2;

            return Math.Sqrt(s * (s - _Side1) * (s - _Side2) * (s - _Side3));
        }
    }


    
}
