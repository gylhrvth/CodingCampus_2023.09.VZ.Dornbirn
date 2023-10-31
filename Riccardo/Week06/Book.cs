using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Riccardo.Week06.
{
    internal class Book
    {
      
        private string _Autor;
        private string _Title;
        

        public string Title
        {
            get => _Title;

            set
            {
                Console.WriteLine("Book Title ist chaning to: " + value);
                _Title = value;
            }
        }

        public int CountPages;

        public Book(string Autor, string Title)
        {
            _Autor = Autor;
        }
    }
}

