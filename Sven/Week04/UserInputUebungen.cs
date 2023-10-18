using System;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Sven.Week04
{
    internal class UserInputUebungen
    {
        public static void Start()
        {
            Console.WriteLine("String Read:");
            StringRead();
            Console.WriteLine();

            Console.WriteLine("String Read:");
            StringRead2();
            Console.WriteLine();

        }


        public static string StringRead()
        {
            System.String name;

            Console.WriteLine("Bitte gib deinen Namen ein: ");

            name = Console.ReadLine();

            Console.WriteLine("Dein Name ist: " + name);

            return name;

        }

        public static int StringRead2()
        {

            Console.WriteLine("Bitte gib deinen Namen ein: ");

            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    int output = Convert.ToInt32(input);
                    return output;

                }
                catch
                {
                    Console.WriteLine("Bitte nur Zahlen eingeben!");
                }
            }

        }

    }
}
