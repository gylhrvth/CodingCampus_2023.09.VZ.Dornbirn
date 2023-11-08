using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selina.Week06.Test
{
    public class Input
    {
        public static void Start()
        {
            Output("1",ConsoleColor.Blue);
            string text = ReadText("Bitte geben Sie einen Text ein: ", "Das ist kein Text! ");
            int number = ReadNumber("Wie oft soll der Text ausgeben werden? ", "Das ist keine Zahl! ");
            OutputText(text, number);
        }
        public static string Output(string output, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"\n\nAufgabe: {output}");
            Console.ResetColor();

            return output;
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
        public static void OutputText(string text, int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine( $"{i}. {text}");
            }
        }
    }
}
