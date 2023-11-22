using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week07.GeometryInterface
{
    public class Stern : Geometry
    {
        public double _Leangth;

        public Stern(double leangth)
        {
            _Leangth = leangth;
        }

        public double GetCircumfrence()
        {
            return _Leangth * 12;
        }

        public double GetArea()
        {
            return (new Triangle(_Leangth).GetArea()) * 4 + new Square(_Leangth).GetArea();
        }
    }
}
