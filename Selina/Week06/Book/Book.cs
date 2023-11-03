namespace Selina.Week06.Book
{
    public class Book
    {
        private string _Title;
        private string _Autor;
        public string Title
        {
            get => _Title;

            set
            {
                Console.WriteLine("Book Title is changing to: " + value);
                _Title = value;
            }
        }

        public int CountPages = 0;
        public Book(string autor, string title)
        {
            _Autor = autor;
            _Title = title;
            CountPages = -1;
        }

        public override string ToString()
        {
            return string.Format("Autor: {0}\nTitle: {1}\nCount Pages: {3}", _Autor, _Title, CountPages);
        }
    }
}
