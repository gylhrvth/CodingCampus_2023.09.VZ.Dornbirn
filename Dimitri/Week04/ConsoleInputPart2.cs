using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static Dimitri.Week03.ConsoleInput;
using static Dimitri.Week03.Array;

namespace Dimitri.Week04
{
    internal class ConsoleInputPart2
    {


        public static void Main()
        {

            //CalculatorContinue();
            TheGameBegins(9999);

        }

        public static void CalculatorContinue()
        {
            double result = 0;
            double firstNumber = 0;
            double secondNumber = 0;
            string symbol = "";
            bool newCalculation = true; //set true to decide if ther should be a new input for the first number or the result of the last calc should be used
            string continueCalculating = "y"; //used to stop the calculator
            while (continueCalculating == "y")
            {

                //read first number
                while (newCalculation)
                {
                    firstNumber = AskNumber("Enter your first number:", "Something is wrong with your number.");
                    newCalculation = false;
                }


                //read operator
                Console.WriteLine("Enter your operator ( '+' / '-' / '*' / '/' / '^' ):");
                symbol = ReadSymbol(StringRead() + " ");

                //read second number
                secondNumber = AskNumber("Enter your second number:", "Something is wrong with your number.");
                while (secondNumber == 0 && symbol == "/")
                {
                    secondNumber = AskNumber("Division by Zero enter a new Number: ", "Something is wrong with your number.");
                }



                //calculate and print result
                result = CalculateResult(firstNumber, symbol, secondNumber);

                Console.WriteLine("Your result is: {0:0.00000}", result);

                //add memory
                //double memory = Memory()

                //continue calcualting
                Console.WriteLine("Do you wanna continue calculating? (y/n)");
                continueCalculating = AskYN(StringRead());

                if (continueCalculating == "y")
                {
                    Console.WriteLine("Do you wanna continue to calculate with your above result? (y/n)");
                    string keepResult = AskYN(StringRead());

                    if (keepResult == "n")
                    {
                        firstNumber = 0;
                        newCalculation = true;
                    }
                    else
                    {
                        newCalculation = false;
                        firstNumber = result;
                    }

                }
            }



        }

        private static string AskYN(string input)
        {
            while (input.Length > 1 && (input != "n" || input != "y")) // only a single symbol and a set of symbols
            {
                Console.WriteLine("Your input is not valid. Do you wanna continue calculating? (y/n)");
                input = StringRead();
            }

            return input;

        }

        private static string ReadSymbol(string symbol)
        {
            while (symbol.Length > 2 || (symbol != "^ " && symbol != "/ " && symbol != "* " && symbol != "+ " && symbol != "- ")) // only a single symbol and a set of symbols
            {
                Console.WriteLine("Your operator is not valid. Enter a new one:");
                symbol = StringRead() + " ";
            }

            return symbol;
        }

        private static double AskNumber(string prompt, string onError) //, string symbol, bool firstNumber)
        {
            bool isNumber = false;
            double number = double.MinValue;
            //if (firstNumber)
            //{
            while (!isNumber)
            {
                try
                {
                    Console.WriteLine(prompt);
                    number = Convert.ToDouble(StringRead());
                    isNumber = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(onError);
                }
            }

            return number;
        }

        private static int AskInt(string prompt, string onError)
        {
            bool isNumber = false;
            int number = int.MinValue;
            //if (firstNumber)
            //{
            while (!isNumber)
            {
                try
                {
                    Console.WriteLine(prompt);
                    number = Convert.ToInt32(StringRead());
                    isNumber = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(onError);
                }
            }

            return number;
        }

        public static void TheGameBegins(int random)
        {
            Random rand = new Random();
            int value = rand.Next(random);

            int countWrong = int.MinValue;
            int countRight = 0;


            while (countWrong != 0)
            {
                countWrong = 0;
                countRight = 0;
                int input = 0;
                bool NumberOf = false;
                while (!NumberOf)
                {
                    input = AskInt("Enter your number:", "Not a valid Number please reenter your Number");
                    if(input >= 1000 && input < 10000)
                    {
                        NumberOf = true;
                    }
                }
                string valueString = Convert.ToString(value);

                string inputString = Convert.ToString(input);



                string randomString = Convert.ToString(random);

                string[] arrValue = new string[valueString.Length];
                string[] arrInput = new string[inputString.Length];
                int i = 0;
                foreach (char indexCharValue in valueString)
                {

                    string CharOnPositionValue = Convert.ToString(indexCharValue);
                    arrValue[i] = CharOnPositionValue;
                    i++;
                }

                Console.WriteLine("My value arr");
                PrintStringArray(arrValue);

                int j = 0;
                foreach (char indexCharInput in inputString)
                {

                    string charOnPositionInput = Convert.ToString(indexCharInput);
                    arrInput[j] = charOnPositionInput;
                    j++;
                }

                Console.WriteLine("My input arr");
                PrintStringArray(arrInput);

                for (int k = 0; k < valueString.Length; k++)
                {
                    if (arrValue[k] == arrInput[k])
                    {
                        countRight++;
                    }
                    else
                    {
                        countWrong++;
                    }
                }

                Console.WriteLine("{0} Ziffer ist richtig. {1} Ziffern sind falsch.", countRight, countWrong);

            }
        }

        public static void PrintStringArray(string[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {

                if (i < arr.Length - 1)
                {
                    Console.Write(arr[i] + ", ");
                }
                else
                {
                    Console.Write(arr[i]);
                }
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
}
