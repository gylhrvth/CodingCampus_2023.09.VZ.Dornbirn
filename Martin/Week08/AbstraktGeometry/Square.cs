using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week08.AbstraktGeometry
{
    public class Square : Rectangle
    {
        private double _lenght;

        public Square(double lenght) : base(lenght, lenght)
        {
            _lenght = lenght;
        }

        public override double getCircumference()
        {
            return 4 * _lenght;
        }

        public override double getArea()
        {
            return _lenght * _lenght;
        }
    }
}
