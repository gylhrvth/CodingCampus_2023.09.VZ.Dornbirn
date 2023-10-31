using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Week06
{
    public class BookExample
    {
        public static void Start()
        {
            Book b1 = new Book("Hassan", "Über die DateTime Datentypen");
            Book b2 = new Book("Lukas", "Programieren macht Spaß!");
            

            Console.WriteLine(b1.Title);
            Console.WriteLine(b2.Title);
        }
    }
}
