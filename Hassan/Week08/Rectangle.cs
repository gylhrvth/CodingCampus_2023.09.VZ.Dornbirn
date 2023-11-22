using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hassan.Week08
{
    public class Rectangle : Geometry
    {
        private double _lenght;
        private double _height;


        public Rectangle(double length, double height)
        {
            _lenght = length;
            _height = height;
        }

        public override double GetCircumference()
        {
            return 2 * _lenght + 2 * _height;
        }

        public override double GetArea()
        {
            return _lenght * _height;
        }

    }
}
