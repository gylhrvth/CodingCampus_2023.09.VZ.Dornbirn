using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Patrick.Week02.MethodeSchleifen;

namespace Patrick.Week04.ConsoleInputs
{
    internal class ConsoleInput
    {
        public static Random random = new Random();

        public static void Start()
        {
            //AUFGABE 1
            Console.WriteLine("Write the input: ")
            Console.WriteLine("The Inputstring = " + StringRead());                       //Lies mit Hilfe von .... ein String des Benutzers ein und gib diesen aus          


            //AUFGABE 2
            Console.WriteLine("Write the inputNumber: ");
            Console.WriteLine("The inputNumber = " + IntegerRead());                      //Frage so lange nach einer Zahl, bis eine eingegeben wurde, das Programm darf bei Fehleingabe nicht abstürtzen!!


            //AUFGABE 4
            Console.Write("Was wäre das Minimum? >>> ");
            int low = ReadNumber(0, int.MaxValue-1);                                        //Erweitere deine frühere Lösung so, dass die Parameter über die Konsole eingegeben werden können
            Console.Write("Was wäre das Maximum? >>> ");
            int high = ReadNumber(low + 1, int.MaxValue);
            //AUFGABE 3
            Console.WriteLine(QuizGame(low, high));                                         //Nun soll die Zahl durch Eingabe über die Konsole erraten werden. Ist die Zahl zu hoch oder zu niedrig, so soll diese Information ausgegeben werden. Wurde die Zahl getroffen, so ist das Spiel gewonnen und das Programm wird beendet.


            //AUFGABE 5
            Menu("", 1, 3);
        }


        public static string StringRead()
        {
            string Input = Console.ReadLine();
            return Input;
        }

        public static int IntegerRead()
        {
            while (true)
            {
                string input = Console.ReadLine();
                try
                {
                    return Convert.ToInt32(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("\"{0}\" is not a Number, please try again: ", input);
                }
            }
        }


        public static bool StringReadYesOrNo()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "yes")
                {
                    return true;
                }
                else if (input == "no")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please select yes or no!");
                }
            }
        }


        public static int ReadNumber(int low, int high)
        {
            int result = int.MinValue;
            while (result == int.MinValue)
            {
                string line = Console.ReadLine();

                try
                {
                    result = Convert.ToInt32(line);

                    if (result < low || result > high)
                    {
                        Console.WriteLine("the Number \"{0}\" is not in the range", line);
                        result = int.MinValue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("{0} is no vaild Number.", line);
                }
            }
            return result;
        }

        public static int QuizGame(int low, int high)
        {

            int randomNumber = random.Next(low, high);
            int input = 0;

            Console.WriteLine("Welcome to the super cool Numbers Quizgame");
            Console.WriteLine("Guess the right Number between {0} and {1}", low, high);
            Console.WriteLine("Write the Number:  ");


            while (true)
            {
                input = ReadNumber(low, high);


                if (input < randomNumber)
                {
                    Console.WriteLine("The number is to low!");
                }
                else if (input > randomNumber)
                {
                    Console.WriteLine("The number is to high!");
                }
                else
                {
                    Console.WriteLine("You are the Winner!");
                    break;
                }
            }
            return input;
        }

        public static void Menu(string symbol, int low, int high)
        {
            Console.WriteLine("Welcome to the Example!");

            while (true)
            {
                Console.WriteLine("What you want to print?");
                Console.WriteLine("1) Christmastree");
                Console.WriteLine("2) Quader");
                Console.WriteLine("3) Rhombus");
                Console.WriteLine("Please select now between 1 - 3: ");
                int inputWhat = Convert.ToInt32(ReadNumber(low, high));
                int inputSize = 0;
                int inputSizeQuader = 0;

                if (inputWhat == 1)
                {
                    Console.WriteLine("How big should be your Christmastree?");
                    inputSize = Convert.ToInt32(ReadNumber(int.MinValue, int.MaxValue));
                    Console.WriteLine("Please select your Symbol");
                    symbol = StringRead();
                    printChristmasTree(symbol, inputSize);

                }

                else if (inputWhat == 2)
                {
                    Console.WriteLine("How big should be your Quader (column)?");
                    inputSize = Convert.ToInt32(ReadNumber(int.MinValue, int.MaxValue));
                    Console.WriteLine("How big should be your Quader (row)?");
                    inputSizeQuader = Convert.ToInt32(ReadNumber(int.MinValue, int.MaxValue));
                    Console.WriteLine("Please select your Symbol");
                    symbol = StringRead();
                    printRect(symbol, inputSize, inputSizeQuader);

                }

                else if (inputWhat == 3)
                {
                    Console.WriteLine("How big should be your Rhombus?");
                    inputSize = Convert.ToInt32(ReadNumber(int.MinValue, int.MaxValue));
                    Console.WriteLine("Please select your Symbol");
                    symbol = StringRead();
                    printRhombus(symbol, inputSize);

                }

                Console.WriteLine("Do you want to print something again? (tip yes or no)");

                if (!StringReadYesOrNo())
                {
                    break;
                }
            }
        }
    }
}
