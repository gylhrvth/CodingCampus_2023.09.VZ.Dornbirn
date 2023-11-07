namespace Fabian.Week06.Book
{
    public class BookExample
    {
        public static void Start()
        {
            Book b1 = new("Adi", "Nazi Deutschland");
            Book b2 = new("Lukas", "Programmieren macht Spaß!");

            b1.CountPages = 88;
            Console.WriteLine(b1);

        }
    }
}
