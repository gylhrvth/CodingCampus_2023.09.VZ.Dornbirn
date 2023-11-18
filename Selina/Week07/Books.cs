using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selina.Week07
{
    public class Books
    {
        public static void Start()
        {
            List<Book> list = new List<Book>();

            list.Add(new Book(300, "The Hunger Games", "Could you survive on your own in the wild, with every one out to make sure you don't " +
                              "live to see the morning?"));
            list.Add(new Book(300, "Catching Fire", "Against all odds, Katniss Everdeen has won the Hunger Games."));
            list.Add(new Book(300, "Mockingjay", "Katniss Everdeen, girl on fire, has survived, even though her home has been destroyed. "));
            list.Add(new FantasyBook(500, "The Ballad of Songbirds and Snakes", "It is the morning of the reaping that will kick off the tenth " +
                "annual Hunger Games.In the Capital, eighteen - year - old Coriolanus Snow is preparing for his one shot at glory as a mentor in the G" +
                "ames.", "Fantasy Buch"));

            foreach(Book book in list)
            {
                Console.WriteLine(book.title);
            }
        }
    }
}
