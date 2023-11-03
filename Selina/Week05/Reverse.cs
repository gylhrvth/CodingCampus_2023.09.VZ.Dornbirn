using System;

namespace Selina.Week05
{
    internal class Reverse
    {
        public static Random random = new Random();
        public static void Start()
        {
            string reversWord;
            string shuffledWord;
            string input;

            //Aufgabe 1:
            Output("Aufgabe: Reverse", ConsoleColor.Red);
            input = ReadText("Willkommen zum Reverseprogramm\n");     //User gibt Text ein

            reversWord = ReverseText(input);    //Text wird umgekehrt              
            PrintText(reversWord);              //Text wird ausgeben 
            Console.WriteLine("\n-----------------------------------------------------");

            //Aufagbe 2:
            Output("Aufgabe: Randomize", ConsoleColor.Yellow);
            input = ReadText("Willkommen zum Zufallsshuffle Programm\n");
            shuffledWord = Randomize(input);
            PrintText(shuffledWord);

            //Aufagbe 3:
            Output("Aufgabe: Buchstaben zählen", ConsoleColor.Green);
            string text = Ressources.StringRessources.getText();
            Console.WriteLine(text);

            int[]count = CountLetters(text);
            PrintBuchstaben(count);

            for(int i = 2; i < 10; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    

        public static void PrintBuchstaben(int[] count)
        {
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > 0)
                {
                    Console.WriteLine($"{(char)i}: {count[i]}");
                }
            }
        }
        public static int[] CountLetters(string text)
        {
            int[] count = new int[char.MaxValue];
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                ++count[c];
            }
            return count;
        }
        public static string Randomize(string input)
        {
            char[] charArray = input.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {   
                int randomIndex = random.Next(charArray.Length);
                char temp = charArray[i];
                charArray[i] = charArray[randomIndex];
                charArray[randomIndex] = temp;
            }
            return new String(charArray);
        }
        public static string ReverseText(string input)
        {
            char[] charArray = input.ToCharArray();
            char[] arr = new char[charArray.Length];
            for (int i = 0; i < charArray.Length; i++)
            {
                arr[i] = charArray[input.Length - i - 1];
            }
            return new String(arr);
        }
        public static string ReadText(string prompt)
        {
            Console.Write(prompt);
            while (true)
            {
                try
                {
                    string text = Convert.ToString(Console.ReadLine());
                    return text;
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);

                }
            }
        }
        public static void PrintText(string text)
        {
            foreach (var item in text)
            {
                Console.Write(item);
            }
        }
        public static void Output(string output, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"\n\n {output}");
            Console.ResetColor();
        }
    }
}
