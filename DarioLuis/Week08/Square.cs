using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Week08
{
    public class Square:Geometry
    {
        private double _Length;
        public Square(double length) 
        { 
            _Length = length;
        }

        public override double getArea()
        {
            return _Length* _Length;
        }

        public override double getCircumference()
        {
            return 4 * _Length;
        }
    }
}
