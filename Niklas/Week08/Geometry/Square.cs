using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week08.Geometry
{
    public class Square : Rectangle
    {
        public double _lenght;
        public Square(double width, double height, double lenght) : base(height, width)
        {
            _lenght = lenght;
        }

        public override double getArea()
        {
            return _lenght * _lenght;
        }
        public override double getCircumference()
        {
            return _lenght * 4;
        }
    }
}
