using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week06.Book
{
    public class BookExample
    {
        public static void Start()
        {
            Book b1 = new Book("Martin", "Meine beste Rezepte");

            Console.WriteLine(b1);
            Console.WriteLine(b1.Title);
            b1.Title = "Mein Hobby";
            b1.CountPages = 100;

            Console.WriteLine(b1);
        }
    }
}
