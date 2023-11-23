using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week08.InterfaceGeometry
{
    public class Square : Rectangle
    {
        private double _lenght;

        public Square(double lenght) : base(lenght, lenght)
        {
            _lenght = lenght;
        }

        public  double getCircumference()
        {
            return 4 * _lenght;
        }

        public  double getArea()
        {
            return _lenght * _lenght;
        }
    }
}
