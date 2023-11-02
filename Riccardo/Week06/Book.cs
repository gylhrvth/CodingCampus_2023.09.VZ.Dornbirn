using Riccardo.Week06.Book;
using System;
namespace Riccardo.Week06
    {
    public class Person
        {

        private int _Height;
        private int _Age;
        private string _Name;
        private int _Weight;

        public int CountPages;


        public Book(string Author, string Title)
        {
            _Author = Author;
            _Title = Title;
            CountPages = -1;
        }

        public override string ToString()
        {
            return string.Format("Author: {0}\nTitle: {1}\nCount Pages: {2}",
                _Author,
                _Title,
                CountPages);
        }
    }
}


