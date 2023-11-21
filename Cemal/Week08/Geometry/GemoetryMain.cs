using Cemal.Week08.Geometry.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week08.Geometry
{
    public class GemoetryMain
    {
        public static void Start()
        {
            Circle c1 = new Circle(7);
            Circle c2 = new Circle(20);

            Triangle t1 = new Triangle(14);
            Triangle t2 = new Triangle(18);

            Rectangle r1 = new Rectangle(10, 15);
            Rectangle r2 = new Rectangle(5, 13);
            

            Square s1 = new Square(10);
            Square s2 = new Square(5);


            List<Circle> circles = new List<Circle>()
            {
                c1,c2
            };

            List<Triangle> triangles = new List<Triangle>()
            {
                t1,t2
            };

            List<Rectangle> rectangles = new List<Rectangle>() 
            {
                r1,r2
            };

            List<Square> squares = new List<Square>() 
            {
                s1,s2
            };


            foreach (Circle c in circles)
            {
                Console.WriteLine("Umfang vom Kreis: {0,10:N2}", c.getCircumference());
                Console.WriteLine("Fläche vom Kreis: {0,10:N2}", c.getArea());
                Console.WriteLine();
            }

            foreach (Triangle t in triangles)
            {
                Console.WriteLine("Umfang vom Dreieck: {0,10:N2}", t.getCircumference());
                Console.WriteLine("Fläche vom Dreieck: {0,10:N2}", t.getArea());
                Console.WriteLine();
            }

            foreach (Rectangle r in rectangles)
            {
                Console.WriteLine("Umfang vom Rechteck: {0,10:N2}", r.getCircumference());
                Console.WriteLine("Fläche vom Rechteck: {0,10:N2}", r.getArea());
                Console.WriteLine();
            }

            foreach (Square s in squares)
            {
                Console.WriteLine("Umfang vom Quadrat: {0,10:N2}", s.getCircumference());
                Console.WriteLine("Fläche vom Quadrat: {0,10:N2}", s.getArea());
                Console.WriteLine();
            }

        }
    }
}
