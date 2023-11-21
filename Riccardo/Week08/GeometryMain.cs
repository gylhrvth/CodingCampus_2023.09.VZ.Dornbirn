using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riccardo.Week08
{
    public class GeometryMain
    {
        public static void Start()
        {
            Circle circle = new Circle(8);
            Triangle triangle = new Triangle(7);
            Square square = new Square(11);
            Rectangle rectangle = new Rectangle(6,6);

            List<Geometry> list = new List<Geometry>()
            {
                circle, triangle, square, rectangle
            };


            double sumArea = 0;
            double sunCurcum = 0;

            foreach (Geometry g in list)
            {
                sumArea += g.GetArea();
                sunCurcum += g.GetCircumfence();
                
            }

            Console.WriteLine("Die Gesamt Fläche ist: " + sumArea);
            Console.WriteLine("Der Gesamt Umfang ist: " + sunCurcum);
        }
    }
}
