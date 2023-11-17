using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Week06
{
    public class Book
    {
        private string _Title;
        private string _Author;
        private int _CountPages;
        public string Title { get => _Title; }
        public Book(string Author, string Title) 
        {
            _Author = Author;
            this._Title = Title;
            _CountPages = -1;
        }
    }
}
