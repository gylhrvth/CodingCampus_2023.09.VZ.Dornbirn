namespace Gheorghe.Week01
{
    internal class Methoden
    {
        public static void Start()
        {
            PrintChars("g", 10);
        }

        public static void PrintChars(string symbol, int count)
        {
            for (int k = 0; k < count; k++)
            {
                Console.Write(symbol);
            }
        }

    }
}
