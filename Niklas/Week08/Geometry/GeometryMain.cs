using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week08.Geometry
{
    public class GeometryMain
    {
        public static void Start()
        {
            List<Geometry> list = new List<Geometry>();

            list.Add(new Triangle(10));
            list.Add(new Circle(10));
            list.Add(new Rectangle(10, 5));
            list.Add(new Square(5, 5, 5));


            foreach (Geometry geometry in list)
            {
                Console.WriteLine("Circum: " + geometry.getCircumference());
                Console.WriteLine("Area: " + geometry.getArea());
                
            }
            
            double sumArea = 0;
            double sumCircums = 0;

            foreach (Geometry geometry in list)
            {
                sumCircums += geometry.getCircumference();
                sumArea += geometry.getArea();
            }
            Console.WriteLine("Die Summe Alle Flächen ist: " + sumArea);
            Console.WriteLine("Die Summe Alle Umfänge ist: " + sumCircums);
        }


    }
}
