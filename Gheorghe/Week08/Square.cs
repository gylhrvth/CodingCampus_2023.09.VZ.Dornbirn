using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe.Week08
{
    internal class Square : Geometry
    {
        private double _sideLength;

        public Square(double sideLength)
        {
            _sideLength = sideLength;
        }

        public virtual double getArea()
        {
           
            return _sideLength * _sideLength;
        }

        public virtual double GetCircumference()
        {
            return 4 * _sideLength;
                 

        }





    }
}
