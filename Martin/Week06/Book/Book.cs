using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week06.Book
{
    public class Book
    {
        private string _Author;
        private string _Title;

        public string Title
        {
            get
            {
                return "\"" + _Title + "\"";
            }

            set
            {
                Console.WriteLine("Book Title is changing to:" + value);
                _Title = value;
            }
        }

        public int CountPages;

        public Book(string Author,string Title) 
        {
            _Author = Author;
            _Title = Title;
            CountPages = -1;

        }

        public override string ToString()
        {
            return string.Format("Author: {0}\n Title:{1}\n Count pages: {2}",
                _Author,
                _Title,
                CountPages
                );
        }
    }
}
