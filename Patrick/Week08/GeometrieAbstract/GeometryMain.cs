using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.GeometrieAbstract
{
    internal class GeometryMain
    {

        public static void Start()
        {
            Triangle triangle1 = new Triangle(100.58f);

            Rectangle rectrangle1 = new Rectangle(30.56f, 87.78f);

            Circle circle1 = new Circle(38.786f);

            Square square1 = new Square(15.57f);


            List<Geometrie> list = new List<Geometrie>()
            {
                triangle1,
                circle1,
                rectrangle1,
                square1

            };

            foreach(Geometrie geometrie in list)
            {
                Console.WriteLine("DerUmfang von Beträgt = " + geometrie.GetCircumference() + "cm");
                Console.WriteLine("Die Fläche Beträgt = " + geometrie.GetArea() + "cm²"); ;
                Console.WriteLine();
            }

            double uGes = 0;
            double aGes = 0;
            foreach (Geometrie geometrie in list)
            {
                uGes += geometrie.GetCircumference();
                aGes += geometrie.GetArea();
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Der Gesamtumfang beträgt = " + uGes + "cm");
            Console.WriteLine("Die Gesamtfläche beträgt = " + aGes + "cm²");
            Console.ResetColor();
        }




    }
}
