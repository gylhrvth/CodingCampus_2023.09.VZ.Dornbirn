using System.Data;

namespace Fabian.Selftest_SP
{
    public class Methods
    {
        public static void Start()
        {
            //PrintLineStipple("X", 10);
            //PrintRowStipple("X", 3);
            //ReUseMethods();
            PrintSlash("x", 3, true);
            PrintSlash("y", 4, false);
        }

        public static void PrintLineStipple(string symbol, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.Write(symbol + " ");
            }
        }
        public static void PrintRowStipple(string symbol,int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine(symbol + "\n");
            }
        }
        public static void ReUseMethods()
        {
            PrintLineStipple("X", 3);
            Console.WriteLine();
            PrintRowStipple("X", 3);
        }
        public static void PrintSlash(string symbol, int amount, bool backSlash)
        {
            if (backSlash)
            {
                for (int i = 0; i < amount; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine(symbol);
                }
            }
            else
            {

                for (int i = 0; i < amount; i++)
                {
                    for (int j = 0; j < amount - i - 1; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine(symbol);
                }
            }
        }
    }
}
