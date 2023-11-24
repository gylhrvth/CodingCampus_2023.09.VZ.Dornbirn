using Gheorghe.Week07.Vererbung;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Gheorghe.Week07.Vererbung.Abstractsshape;

namespace Gheorghe.Week08
{
    internal class GeometryMain
    {

        public static void Start()
        {

            double totalArea = 0;
            double totalCircumference = 0;
            List<Geometry> Shapes = new List<Geometry>();


            Circle c = new Circle(5);
            Square c1 = new Square(10);
            Rectangle c2 = new Rectangle(12, 7);
            Triangle c3 = new Triangle(10, 5);

            Shapes.Add(c);
            Shapes.Add(c1);
            Shapes.Add(c2);
            Shapes.Add(c3);

           


            // Liste iterieren
            foreach (Geometry geometry in Shapes)
            {
               
                totalArea += geometry.getArea();
                totalCircumference += geometry.GetCircumference();
            }
            
            Console.WriteLine("Total Area:" + totalArea);
            Console.WriteLine("Total Circumfernce:" +  (totalCircumference / totalArea) / totalCircumference);

        }

    }

}



