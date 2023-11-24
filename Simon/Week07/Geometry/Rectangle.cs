using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week07.Geometry
{
    public class Rectangle : Geometry
    {
        public double _Width;
        public double _Height;

        public Rectangle(double width, double height)
        {
            _Width = width;
            _Height = height;
        }

        public override double getCircumfrence()
        {
            return (_Width *2) + (_Height *2);
        }

        public override double getArea()
        {
            return Math.Pow(_Width * _Height, 2);
        }


    }
}
