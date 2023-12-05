using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Week08.Geometry
{
    public  class GeometryMain 
    {
       
       public static void Start()
        {
            Circle c1 = new Circle(2);
            Circle c2 = new Circle(5);

            Square s1 = new Square(10);
            Square s2 = new Square(31);

            Rectangle r1 = new Rectangle(11, 5);
            Rectangle r2 = new Rectangle(13, 5);

            Triangle t1 = new Triangle(5, 3);
            Triangle t2 = new Triangle(10, 5);




            List<object> list = new List<object>()
            {
                c1,c2,s1,s2,r1,r2,t1,t2
            };

            double sumCircum = 0;
            double sumArea = 0;



            foreach (Geo geo in list)
            {


                Console.WriteLine("Der Umfang ist: " + geo.GetCircumference());
                Console.WriteLine("Die Fläche ist: " + geo.GetArea());


            }

            foreach (Geo geo in list)
            {


                sumCircum = sumCircum + geo.GetCircumference();
                sumArea = sumArea + geo.GetArea();


            }



            Console.WriteLine("sumCircum:" + sumCircum);
            Console.WriteLine("sumArea:" + sumArea);
        }
    }
}
        
          

    

