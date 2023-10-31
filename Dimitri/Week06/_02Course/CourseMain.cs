using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dimitri.Week06._01Person;

namespace Dimitri.Week06._02Course
{
    internal class CourseMain
    {
        public static void Main()
        {
            Person p = new(174, 31, "Dimitri", 64);
            Course c = new("Softwareentwickler", "26.09.2023", 500, 7840.99, p);
            Course c1 = new("Softwareentwickler", "26.09.2023", 500, p);

            Console.WriteLine(c);
            Console.WriteLine();
            Console.WriteLine(c1);
            Console.WriteLine();
            Console.WriteLine(c.Title);
            c.Title = "Angehender Softwareentwickler";
            Console.WriteLine(c.Title);
            Console.WriteLine();
            //Console.WriteLine("Preis alt: " + c1._Price);
            //c1._Price = 9999;
            //Console.WriteLine("Preis neu: " + c1._Price);

        }
    }
}
