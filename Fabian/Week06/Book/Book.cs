namespace Fabian.Week06.Book
{
    public class Book
    {
        private string _Title;
        private string _Author;
        public string Title 
        {
            get => _Title;

            set
            {
                Console.WriteLine("Book title is changing to: " + value);
                _Title = value;
            }
        }
        public string Author
        {
            get => Author;

            set
            {
                Console.WriteLine("Book author is changing to: " + value);
                _Author = value;
            }
        }
        public int CountPages;
        public Book(string author, string title)
        {
            this._Title = title;
            this._Author = author;
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
