using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selina.Week07
{
    public class FantasyBook : Book
    {
        private string kindOfBook;
        public FantasyBook(int numberOfPages, string title, string text, string kindOfBook) : base(numberOfPages, title, text)
        {
            this.kindOfBook = kindOfBook;
        }
        public override string ToString()
        {
            return kindOfBook;
        }
    }
}
