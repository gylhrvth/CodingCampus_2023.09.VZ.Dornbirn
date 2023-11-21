using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Kerem.Week08
{
    internal class GeometryMain
    {
        public static void Start()
        {
            Circle c1 = new Circle(10);
            Circle c2 = new Circle(5);

            Rectangle r1 = new Rectangle(10,13);
            Rectangle r2 = new Rectangle(7,15);

            Triangle t1 = new Triangle(5, 12);
            Triangle t2 = new Triangle(15, 5);

            Square s1 = new Square(6);
            Square s2 = new Square(9);


            List<object> obj = new List<object>()
            {
              c1, c2, r1, r2, t1, t2, s1, s2
              
            };


            foreach(Geometry geo in obj)
            {
                Console.WriteLine("Umfang:" + geo.CircumFerence());
                Console.WriteLine("Fläche:" + geo.GetArea());
            }



        }
        
       
    }
}
