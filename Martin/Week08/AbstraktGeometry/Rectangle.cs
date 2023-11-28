using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week08.AbstraktGeometry
{
    public class Rectangle : Geometry
    {
        private double _lenght;
        private double _height;

        public Rectangle(double lenght, double height)
        {
            _lenght = lenght;
            _height = height;
        }

        public override double getArea()
        {
            return _height * _lenght;
        }

        public override double getCircumference()
        {
            return 2 * (_lenght + _height);
        }
    }
}
