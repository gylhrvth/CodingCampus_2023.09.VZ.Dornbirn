using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week07._05Geometry
{
    public class Circle
    {
        private double _Radius;

        public Circle(double radius)
        {
            _Radius = radius;
        }

        public double Radius
        { get => _Radius; }


        //get Circurcumverenze: 
        public static double GetUmfang(double radius)
        {
            return 2*Math.PI*radius;
        }
        public static void GetFlaeche(double radius)
        {

        }
    }
    
}
