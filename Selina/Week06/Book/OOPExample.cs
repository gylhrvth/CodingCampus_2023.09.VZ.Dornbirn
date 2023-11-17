namespace Selina.Week06.Book
{
    public class OOPExample
    {
        private string _Name;
        public OOPExample(string Name)
        {
            _Name = Name;
        }
        public static void Start()
        {
            Console.WriteLine("Hello World!");
            Private();
        }
        private static void Private()
        {
            System.Console.WriteLine("This is a private method");
        }
        public string GetHello()
        {
            return "Hello" + _Name + "!!!";
        }

  
    }
}
