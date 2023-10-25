namespace Selina.Week05
{
    internal class Reverse
    {
        public static void Start()
        {
            string reversWord;
            string shuffledWord;
            string input;

            //Aufgabe 1:
            Output("Aufgabe: Reverse", ConsoleColor.Red);
            input = ReadNumber("Willkommen zum Reverseprogramm\n");     //User gibt Text ein

            reversWord = ReverseText(input);    //Text wird umgekehrt              
            PrintText(reversWord);              //Text wird ausgeben 
            Console.WriteLine("\n-----------------------------------------------------");

            //Aufagbe 2:
            Output("Aufgabe: Randomize", ConsoleColor.Yellow);
            input = ReadNumber("Willkommen zum Zufallsshuffle Programm\n");
            shuffledWord = Randomize(input);
            PrintText(shuffledWord);
        }

        public static string Randomize(string input)
        {
            char[] charArray = input.ToCharArray();
            Random random = new Random();

            for (int i = 0; i < charArray.Length; i++)
            {
                int randomIndex = random.Next(charArray.Length);
                char temp = charArray[i];
                charArray[i] = charArray[randomIndex];
                charArray[randomIndex] = temp;
            }

            string shuffledWord = new String(charArray);
          
            return shuffledWord;
        }

        public static string ReverseText(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversedWord = new String(charArray);

            return reversedWord;
        }
        public static string ReadNumber(string prompt)
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
            Console.WriteLine($"\n\nAufgabe: {output}");
            Console.ResetColor();
        }
    }
}
