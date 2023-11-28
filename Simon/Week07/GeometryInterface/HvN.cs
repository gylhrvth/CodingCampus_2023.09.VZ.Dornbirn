using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week07.GeometryInterface
{
    public class HvN : IGeometry
    {
        public double _Leangth;

        public HvN(double leangth)
        {
            _Leangth = leangth;
        }

        public double GetCircumfrence()
        {
            return _Leangth * 5;
        }

        public double GetArea()
        {
            return new Triangle(_Leangth).GetArea() + new Square(_Leangth).GetArea();
        }

    }
}
