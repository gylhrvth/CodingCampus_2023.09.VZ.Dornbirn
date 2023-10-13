using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week03
{
    internal class ConsoleInput
    {
        public static void Main()
        {
            //Console.WriteLine("Write your input here:");
            //StringOutput(StringRead());

            //string prompt = "Write your integer here:";
            //string onError = "Input not allowed. Please enter an Integer:";
            //IntOutput(IntRead(prompt, onError));

            //GuessingGame();

            Menu();
        }

        public static string StringRead()
        {
            string input = Console.ReadLine();
            return input;

        }

        public static void StringOutput(string input)
        {
            Console.WriteLine("This is your input:");
            Console.WriteLine(input);

        }

        public static int IntRead(string prompt, string onError)
        {
            Console.WriteLine(prompt);
            while (true)
            {
                try
                {
                    String input = Console.ReadLine();
                    int ourNumber = Convert.ToInt32(input);
                    return ourNumber;
                }
                catch (Exception e)
                {
                    Console.WriteLine(onError);
                }
            }
        }

        public static void IntOutput(int input)
        {
            Console.WriteLine("This is your integer: " + input);
        }

        public static void GuessingGame()
        {
            int randomNum = new Random().Next(0, 101);

            Console.WriteLine("Willkommen beim super coolen Zahlen Ratespiel!");
            Console.WriteLine("Errate die Zahl zwischen 0 und 100!");

            int num = 0;

            while (num != randomNum)
            {
                num = IntRead("Gib die Zahl nun ein:", "Input not allowed. Please enter an Integer:");
                if (num > randomNum)
                {
                    Console.WriteLine("Die Zahl ist zu hoch!");
                }
                else if (num < randomNum)
                {
                    Console.WriteLine("Die Zahl ist zu niedrig!");
                }
                else
                {
                    Console.WriteLine("Du hast gewonnen!!!");
                }
            }
        }

        public static void Menu()
        {
            Console.WriteLine("Willkommen bei meinen Aufgaben!");
            Console.WriteLine("Was möchten Sie zeichnen?");
            Console.WriteLine("1) Christbaum");
            Console.WriteLine("2) Quader");
            Console.WriteLine("3) Rhombus");
            int num = IntRead("Bitte wählen Sie nun(1/2/3):", "Input not allowed. Please enter an Integer:");

            if (num == 1)
            {
                int height = IntRead("Wie hoch soll der Baum sein?", "Input not allowed. Please enter an Integer:");
                Dimitri.Week02.MethodenUndSchleifen.PrintChristmasTree(height);

            }

            if (num == 3)
            {
                int height = IntRead("Wie hoch soll der Rhombus sein?", "Input not allowed. Please enter an Integer:");
                Console.WriteLine("Welches Symbol soll verwendet werden?");
                string symbol = StringRead();
                Dimitri.Week02.MethodenUndSchleifen.PrintRhombus(symbol, height);

            }

            if (num == 2)
            {
                int height = IntRead("Wie hoch soll der Quader sein?", "Input not allowed. Please enter an Integer:");
                Console.WriteLine("Welches Symbol soll verwendet werden?");
                string symbol = StringRead();
                Dimitri.Week02.MethodenUndSchleifen.PrintEmptySquare(symbol, height);

            }


        }

    }

}
