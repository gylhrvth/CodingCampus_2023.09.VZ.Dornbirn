using System;
namespace Gyula.Week06.Book
{
	public class Book
	{
        private string _Author;
        private string _Title;

		public string Title {
			get => _Title;

			set
			{
				Console.WriteLine("Book Title is changing to: " + value);
				_Title = value;
			}
		}

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

