using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Week08.Geometry
{
    public class Triangle : Geo
    {


        private double _length;
        private double _heigth;
        

        public Triangle(double length, double heigth)

        {
            _length = length;
            _heigth = heigth;
            


        }
        public override double GetCircumference()
        {
           return 3* _length;
        }

        public override double GetArea()
        {
            return  _length* _heigth/2;
        }




    }



}
