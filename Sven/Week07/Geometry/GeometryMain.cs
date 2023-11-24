using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sven.Week07.Geometry
{
    internal class GeometryMain
    {
        public static void Start()
        {
            Circle c1 = new Circle(10);
            Circle c2 = new Circle(5);

            Rectangle r1 = new Rectangle(11, 13);
            Rectangle r2 = new Rectangle(7, 15);

            Triangle t1 = new Triangle(5, 17);
            Triangle t2 = new Triangle(14, 6);

            Square s1 = new Square(7);
            Square s2 = new Square(10);


            List<object> obj = new List<object>()
            {
              c1, c2, r1, r2, t1, t2, s1, s2

            };
            double sumCircumference = 0;
            double sumArea = 0;

            foreach (Geometry o in obj)
            {
                sumCircumference += o.CircumFerence();
                sumArea += o.GetArea();
            }
            Console.WriteLine("Circumference: {0:N3} cm", sumCircumference);
            Console.WriteLine("Area: {0:N3} cm^2", sumArea);


            foreach (Geometry geo in obj)
            {
                Console.WriteLine("Umfang:" + geo.CircumFerence());
                Console.WriteLine("Fläche:" + geo.GetArea());
            }


        }


    }
}
