using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week05
{
    internal class Reverse_Randomize_LetterCounter
    {
        public static void Start()
        {
            //    Console.WriteLine("Willkommen zum Reverseprogramm, Geben Sie einen Text ein: ");
            //    Console.Write(">>>>>");
            //    string input = Console.ReadLine();
            //    Console.WriteLine("Dein eingegebener Text wurde umgedreht: ");
            //    Console.Write("<<<<<");
            //    Console.WriteLine(Reverse(input));

            //    Console.WriteLine("Willkommen zum Zufallsshuffle Programm, Geben Sie einen Text ein: ");
            //    Console.Write(">>>>>");
            //    string inputRandom = Console.ReadLine();
            //    Console.WriteLine("Dein eingegebener Text wurde \"random\" sortiert: ");
            //    Console.Write(">>>>>");
            //    Console.WriteLine(Randomize(inputRandom));

            Console.WriteLine("Willkommen zum Buchstabenzählen deines Textes, Geben sie einen Text ein: ");
            Console.Write(">>>>>");
            string text = Console.ReadLine();
            Console.WriteLine("Dein Ergebnis lautet: ");
            LetterCounter(text);
        }

        public static string Reverse(string input)
        {
            char[] array = input.ToCharArray();
            for (int i = 0; i < array.Length / 2; i++)
            {
                (array[array.Length - i - 1], array[i]) = (array[i], array[array.Length - i - 1]);
            }
            string output = new string(array);

            return output;
        }

        public static string Randomize(string inputRandom)
        {
            Random random = new Random();

            char[] array = inputRandom.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                int indexRandom = random.Next(0, inputRandom.Length);
                char temp = array[indexRandom];
                array[indexRandom] = array[i];
                array[i] = temp;
            }

            string output = new string(array);

            return output;
        }

        public static int[] LetterCounter(string input)
        {
            int[] counter = new int[500];

            foreach (int i in input)
            {
                if ((i >= 'A' && i <= 'Z') || i >= 'a' && i <= 'z' || i >= '0' && i <= '9' || i == ' ' || i == '+' || i == '-' || i == '*' || i == '/')
                {
                    counter[i]++;
                }
            }
            for (int i = 0; i < counter.Length; i++)
            {
                if (counter[i] > 0)
                {
                    Console.WriteLine($"{(char)i}: {counter[i]}");
                }
            }
            return counter;
        }

    }
}
