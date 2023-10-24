using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using MessageBox = System.Console;


namespace Selina.Week04.Taschenrechner
{
    internal class Calculate
    {
        public static void Start()
        {
            char userInput;

            do
            {
                int number1 = ReadNumber("\nGib eine Zahl ein: ");  //speichert Zahl in number1 

                Output("Das Ergebnis von der Summe ist: ", Summe(number1), ConsoleColor.Cyan);  //Output für User
                Output("Das Ergebnis vom Faktorial ist: ", Faktorial(number1), ConsoleColor.Magenta);
                Output("Das Ergebnis von Fibonacci ist: ", Fibonacci(number1), ConsoleColor.DarkCyan);

                MessageBox.WriteLine("\n\nMöchten Sie nochmal rechnen? (J/j)?");   // speichert Text in userInput
                userInput = ReadText();

            } while (userInput == 'j' || userInput == 'J');  // so lange bis userInput != J/j

            MessageBox.Clear();

        }

        //Aufagbe 1:
        public static int Summe(int number1)
        {
            if (number1 == 0)
            {
                return 0;
            }
            else
            {
                return number1 + Summe(number1 - 1);
            }
        }

        //Aufgabe 2:
        public static int Faktorial(int number1)
        {
            if (number1 == 1)
            {
                return 1;
            }
            else
            {
                return number1 * Faktorial(number1 - 1);
            }
        }

        //Aufagbe 3:
        public static int Fibonacci(int number1)
        {
            if (number1 == 1 || number1 == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(number1 - 1) + Fibonacci(number1 - 2);
            }
        }

        //Output für User
        public static void Output(string output, int number1, ConsoleColor color)
        {
            MessageBox.BackgroundColor = color;
            MessageBox.ForegroundColor = ConsoleColor.Black;
            MessageBox.Write($"\n{output} \u001b[4m{number1,3}\u001b[0m ");
            MessageBox.ResetColor();
        }

        //speichtert Number wenn der User richtiges Datentype eingeben hat
        public static int ReadNumber(string prompt)
        {
            MessageBox.Write(prompt);
            while (true)
            {
                try
                {
                    int ourNumber = Convert.ToInt32(MessageBox.ReadLine());
                    return ourNumber;
                }
                catch (Exception exc)
                {
                    MessageBox.WriteLine(exc.Message);

                }
            }
        }

        // speichert Text wenn der User richtiges Datentype eingeben hat
        public static char ReadText()
        {
            while (true)
            {
                try
                {
                    char userInput = Convert.ToChar(MessageBox.ReadLine());
                    return userInput;
                }
                catch (Exception exc)
                {
                    MessageBox.WriteLine(exc.Message);

                }
            }
        }


    }
}