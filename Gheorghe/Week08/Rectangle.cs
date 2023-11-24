using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe.Week08
{
    internal class Rectangle : Geometry
    {
        private double _width;
        private double _height;

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }


        public virtual double GetCircumference()
        {
            return 2 * (_width + _height);
        }
        

        public virtual double getArea()
        {
            return _width * _height;
        }
    }
}
