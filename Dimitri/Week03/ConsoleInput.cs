using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

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

            //Menu();

            Calculator();
        }

        public static string StringRead()
        {
            string input = "";
            while (string.IsNullOrEmpty(input) || input == " " || input == "\t")
            {
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input) || input == " " || input == "\t")
                {
                    Console.WriteLine("Your String is Null or Empty. Type in a new String:");
                }
            }
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
            while (num > 3)
            {
                Console.WriteLine("Please Enter a valid Number.");
                num = IntRead("Bitte wählen Sie nun(1/2/3):", "Input not allowed. Please enter an Integer:");
            }
            {

            }
            if (num == 1)
            {
                int height = IntRead("Wie hoch soll der Baum sein?", "Input not allowed. Please enter an Integer:");
                Dimitri.Week02.MethodenUndSchleifen.PrintChristmasTree(height);

            }

            else if (num == 2)
            {
                int height = IntRead("Wie hoch soll der Quader sein?", "Input not allowed. Please enter an Integer:");
                Console.WriteLine("Welches Symbol soll verwendet werden?");
                string symbol = StringRead();
                while (symbol.Length > 1)
                {
                    Console.WriteLine("Your Symbol has more than one charactere");
                    symbol = StringRead();
                }
                Dimitri.Week02.MethodenUndSchleifen.PrintEmptySquare(symbol, height);

            }

            else if (num == 3)
            {
                int height = 2;
                while (height % 2 == 0)
                {
                    height = IntRead("Wie hoch soll der Rhombus sein?", "Input not allowed. Please enter an Integer:");

                    if (height % 2 == 0)
                    {
                        Console.WriteLine("Die Zahl {0} ist gerade. Bitte gib eine ungerade Zahl ein:", height);

                    }
                }


                Console.WriteLine("Welches Symbol soll verwendet werden?");
                string symbol = StringRead();

                while (symbol.Length > 1)
                {
                    Console.WriteLine("Your Symbol has more than one character. Please enter a new Symbol:");
                    symbol = StringRead();
                }

                Dimitri.Week02.MethodenUndSchleifen.PrintRhombus(symbol, height);
            }

        }

        public static void Calculator()
        {
            string continueCalculating = "y";
            while (continueCalculating == "y")
            {
                //read first number
                double firstNumber = 0;
                bool isNumber = false;
                while (!isNumber)
                {
                    try
                    {
                        Console.WriteLine("Enter your first number:");
                        firstNumber = Convert.ToDouble(StringRead());
                        isNumber = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Something is wrong with your number please. The full error is {0}. Reenter it: ", e);
                    }
                }

                Console.WriteLine("Enter your operator:");
                //read operator
                string symbol = StringRead();
                while (symbol.Length > 1 || (symbol != "%" && symbol != "/" && symbol != "*" && symbol != "+" && symbol != "-")) // only a single symbol and a set of symbols
                {
                    Console.WriteLine("Your operator has more than one charactere. Enter a new one:");
                    symbol = StringRead();
                }


                //read second number
                double secondNumber = 0;
                isNumber = false;
                while (!isNumber)
                {
                    try
                    {
                        Console.WriteLine("Enter your second number:");
                        secondNumber = Convert.ToDouble(StringRead());
                        while (secondNumber == 0 && (symbol == "/" || symbol == "%")) // prevent division by zero
                        {
                            Console.WriteLine("Division by zero not possible choose a new second Number:");
                            secondNumber = Convert.ToDouble(StringRead());
                        }
                        isNumber = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Something is wrong with your number please. The full error is {0}. Reenter it: ", e);
                    }
                }

                double result = CalculateResult(firstNumber, symbol, secondNumber);

                Console.WriteLine("Your result is: " + result);


                Console.WriteLine("you wann do another calculation? (y/n)");
                continueCalculating = StringRead();
                while (continueCalculating.Length > 1 && (continueCalculating != "n" || continueCalculating != "y")) // only a single symbol and a set of symbols
                {
                    Console.WriteLine("Your input is not valid. Do you wanna continue calculating? (y/n)");
                    continueCalculating = StringRead();
                }
                if (continueCalculating == "n"){
                    return;
                }
            }

        }

        // simple method to calculate the result
        public static double CalculateResult(double firstNumber, string Operator, double secondNumber)
        {
            double result = 0;
            if (Operator == "+")
            {
                result = firstNumber + secondNumber;
            }

            else if (Operator == "-")
            {
                result = firstNumber - secondNumber;
            }

            else if (Operator == "*")
            {
                result = firstNumber * secondNumber;
            }

            else if (Operator == "/")
            {
                result = firstNumber / secondNumber;
            }

            else if (Operator == "%")
            {
                result = firstNumber % secondNumber;
            }

            return result;

        }

    }

}
