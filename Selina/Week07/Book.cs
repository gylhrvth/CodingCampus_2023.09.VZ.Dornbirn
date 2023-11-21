using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Selina.Week07
{
    public class Book
    {
        private int numberOfPages;
        public string title;
        private string text;

        public string Title { get => title; }
        public string Text { get => text; }

        public Book(int numberOfPages, string title, string text)
        {
            this.numberOfPages = numberOfPages;
            this.title = title;
            this.text = text;
        }

        public virtual string ToString()
        {
            return title;
        }
    }
}
