namespace Selina.Week06.Test
{

    public class Schleifen
    {
        public static void Start()
        {
            Output("1", ConsoleColor.Green);
            Aufagbe1();
            Output("2", ConsoleColor.Green);
            Aufagbe2();
            Output("3", ConsoleColor.Green);
            Aufgabe3();
        }

        public static void Aufagbe1()
        {
            for (int i = 10; i >= 0; i--)
            {
                if (i == 10)
                {
                    Console.Write(" " + i);
                }
                if(i != 10) 
                {
                    Console.Write(" ," + i);
                }
            }
        }
        public static void Aufagbe2()
        {
            for (int i = -30; i <= 30; i++)
            {
                if (i % 3 == 0 && i == -30)
                {
                    Console.Write(" " + i);
                }
                if (i != -30 && i % 3 == 0)
                {
                    Console.Write(" ," + i);
                }
            }
        }
        public static void Aufgabe3()
        {
            int number = 0;
            while (number <= 10)
            {
                if(number > 5)
                {
                    Console.WriteLine("\n");
                }
                Console.WriteLine(number);
                number++;
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
