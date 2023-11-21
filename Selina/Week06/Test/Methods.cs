using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Selina.Week06.Test
{
    public class Methods
    {
        public static void Start()
        {
            Output("1", ConsoleColor.Cyan);
            string symbol = ReadText("Bitte gib ein Symbol ein: ", "Du musst ein Symbol eingeben! ");
            int amount = ReadNumber("Bitte gib eine Zahl ein: ", "Du musst eine Zahl eingeben! ");
            PrintLineStipple(symbol, amount);

            Output("2", ConsoleColor.Cyan);
            PrintStipple(symbol, amount);

            Output("3", ConsoleColor.Cyan);
            PrintSlash1(symbol, amount);
            Output("4", ConsoleColor.Cyan);
            PrintSlash2(symbol, amount);
        }
        public static void PrintLineStipple(string symbol, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.Write(symbol);
            }
        }
        public static string ReadText(string prompt, string onError)
        {
            Console.Write(prompt);
            while (true)
            {
                try
                {
                    string ourNumber = Convert.ToString(Console.ReadLine());
                    return ourNumber;
                }
                catch (Exception exc)
                {
                    Console.Error.WriteLine(onError);
                }
            }
        }
        public static int ReadNumber(string prompt, string onError)
        {
            Console.Write(prompt);
            while (true)
            {
                try
                {
                    int ourNumber = Convert.ToInt32(Console.ReadLine());
                    return ourNumber;
                }
                catch (Exception exc)
                {
                    Console.Error.WriteLine(onError);
                }
            }
        }
        public static void PrintStipple(string symbol, int amount)
        {
            for (int i = 1; i < amount; i++)
            {
                Console.Write(symbol);
            }
            for (int i = 1; i <= amount; i++)
            {
                Console.WriteLine(symbol);
            }
        }
        public static void PrintSlash1(string symbol, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                for (int y = 0; y <= i; y++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(symbol);
            }
        }
        public static void PrintSlash2(string symbol, int amount)
        {
            for (int j = 0; j < amount; j++)
            {
                for (int i = amount - 1; i > j; i--)
                {
                    Console.Write(" ");
                }

                Console.WriteLine(symbol);
            }
        }
        public static string Output(string output, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"\n\nAufgabe: {output}");
            Console.ResetColor();

            return output;
        }
    }
}
