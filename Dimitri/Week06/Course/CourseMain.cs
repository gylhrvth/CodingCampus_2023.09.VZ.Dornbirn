using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week06.Course
{
    internal class CourseMain
    {
        public static void Main()
        {
            Person.Person p = new Person.Person(174, 31, "Dimitri", 64);
            //Course c = new Course("Softwareentwickler", "26.09.2023", 500, 7840.99, p);
            Course c = new Course("Softwareentwickler", "26.09.2023", 500, p);

            Console.WriteLine(c);
            Console.WriteLine();
            Console.WriteLine(c.Title);
            c.Title = "Angehender Softwareentwickler";
            Console.WriteLine(c.Title);
            Console.WriteLine();
            Console.WriteLine(c.Price);
            c.Price = 9999;
            Console.WriteLine(c.Price);

        }
    }
}
