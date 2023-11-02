using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selina.Week06.Book
{
    public class BookExample
    {
        public static void Start()
        {
            Book b1 = new Book("Hassan", "Über die DateTime Datentyp");
            Book b2 = new Book("Lukas", "Programmieren macht Spaß!");

            Console.WriteLine(b1.Title);
            b1.Title = "blaa blaa";
            b1.CountPages = 120;

            Console.WriteLine(b1.Title);
            Console.WriteLine(b2.Title);
        }
    }
}
