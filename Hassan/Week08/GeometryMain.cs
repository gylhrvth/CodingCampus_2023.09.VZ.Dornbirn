using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hassan.Week08
{
    public class GeometryMain
    {
        public static void Start()
        {
            Rectangle r1 = new(11, 12);
            Rectangle r2 = new(8, 1.9);

            Circle c1 = new(8);
            Circle c2 = new(12.5);

            Triangle t1 = new(5);
            Triangle t2 = new(9);


            List<object> list = new()
            {
                r1, r2, c1, c2, t1, t2

            };

            double sumCircum = 0;
            double sumArea = 0;

            foreach(Geometry geometry in list)
            {
                sumCircum += geometry.GetCircumference();
                sumArea += geometry.GetArea();
            }

            Console.WriteLine("Circumference: {0:N3} cm", sumCircum);
            Console.WriteLine("Area: {0:N3} cm2", sumArea);
        }

    }
}
