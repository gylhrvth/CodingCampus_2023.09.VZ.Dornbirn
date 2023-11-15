using System;
namespace Mohammed.Week06.Book
{
	public class BookEx
	{
		public static void Start()
		{
			Book b1 = new Book("Hassan", "Über die DateTime Datentyp");
			Book b2 = new Book("Lukas", "Programmieren macht viel Spaß!");

			Console.WriteLine(b1.Title);
			b1.Title = "la la la";
			b1.CountPages = 140;

			Console.WriteLine(b1);
			Console.WriteLine(b2);
		}
	}
}

