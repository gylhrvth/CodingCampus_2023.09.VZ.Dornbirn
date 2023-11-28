using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week07.GeometryInterface
{
    public class Rectangle : IGeometry
    {
        public double _Width;
        public double _Height;

        public Rectangle(double width, double height)
        {
            _Width = width;
            _Height = height;
        }

        public double GetCircumfrence()
        {
            return (_Width *2) + (_Height *2);
        }

        public double GetArea()
        {
            return Math.Pow(_Width * _Height, 2);
        }


    }
}
