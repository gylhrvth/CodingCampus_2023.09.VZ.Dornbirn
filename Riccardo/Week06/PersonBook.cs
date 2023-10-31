using Riccardo.Week06.;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riccardo.Week06
{
    internal class PersonBook
    {
        public static void Start()
        {
            Book b1 = new Book("Hassan", "Über die DateTime Datentyp");
            Book b2 = new Book("Lukas", "Programmieren macht Spaß!");

            Console.WriteLine(b1.Title);
            b1.Title = "bla bla bla";
            b1.CountPages = 120;

            Console.WriteLine(b1);
            Console.WriteLine(b2);
        }
    }
}
