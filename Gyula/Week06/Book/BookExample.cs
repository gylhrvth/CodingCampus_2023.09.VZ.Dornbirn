using System;
namespace Gyula.Week06.Book
{
	public class BookExample
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

