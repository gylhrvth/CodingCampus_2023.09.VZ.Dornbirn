using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week08.GeometryInterface
{
    internal class GeometryMain
    {



        public static void Start()
        {



            Circle c1 = new Circle(2);
            Circle c2 = new Circle(5);

            Square s1 = new Square(10);
            Square s2 = new Square(31);

            Rectangle r1 = new Rectangle(11, 5);
            Rectangle r2 = new Rectangle(13, 5);

            Triangle t1 = new Triangle(1);
            Triangle t2 = new Triangle(10);

            List<object> list = new List<object>()
            {
                c1,c2,s1,s2,r1,r2,t1,t2
            };

            double sumCircum = 0;
            double sumArea = 0;



            foreach (Geometry1 geo in list)
            {
                Console.WriteLine("umfang ist: " + geo.getCircumference());
                Console.WriteLine("Fläche ist: " + geo.getArea());
            }

            foreach (Geometry1 geo in list)
            {

                sumCircum = sumCircum + geo.getCircumference();
                sumArea = sumArea + geo.getArea();

            }



            Console.WriteLine("sumCircum:" + sumCircum);
            Console.WriteLine("sumArea:" + sumArea);


        }
       





    }
}
