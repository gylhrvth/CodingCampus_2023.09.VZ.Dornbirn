using System;
using System.Numerics;

namespace David.Week04
{
    public class Rechner
    {
        public static void StartRechner()
        {


            float result = Calculation();


        }

        public static float ReadNumber()
        {

            while (true)
            {
                string numberIn = Console.ReadLine();
                try
                {
                    float result = float.Parse(numberIn);
                    return result;
                }
                catch (FormatException)
                {
                    Console.WriteLine("This isn't a valid number.");
                    Console.WriteLine("Please re-enter a number: ");
                }
            }
        }

        public static string ReadOperator()
        {
            while (true)
            {
                string operat = Console.ReadLine();

                if (operat == "+" || operat == "-" || operat == "*" || operat == "/")
                {
                    return operat;
                }
                else
                {
                    Console.WriteLine("This is no valid operator.");
                    Console.WriteLine("Please enter on of this options: +, -, * or / !");
                }
            }
        }

        public static float Calculation()
        {
            float result = 0;
            while (true)
            {

                Console.WriteLine("Welcome to the calculator!");
                Console.WriteLine("Please enter your 1st number: ");
                float input1 = ReadNumber();

                Console.WriteLine("Please enter now an operator: +, -, * or / !");
                string operat = ReadOperator();

                Console.WriteLine("Please enter your 2nd number: ");
                float input2 = ReadNumber();
                Console.WriteLine();

                if (operat == "+")
                {
                    result = input1 + input2;
                    Console.WriteLine("Your result = " + result);
                    break;
                }

                else if (operat == "-")
                {
                    result = input1 - input2;
                    Console.WriteLine("Your result = " + result);
                    break;
                }

                else if (operat == "*")
                {
                    result = input1 * input2;
                    Console.WriteLine("Your result = " + result);
                    break;
                }

                else if (operat == "/")
                {
                    result = input1 / input2;
                    Console.WriteLine("Your result = " + result);
                    break;
                }

            }
            return result;


        }
    }
}
