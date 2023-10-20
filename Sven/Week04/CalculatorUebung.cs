using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sven.Week04
{
    internal class CalculatorUebung
    {
        public static void Start()
        {
            Calculator();
        }
        public static Char ReadChar(string msg)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(msg);
                    string input = Console.ReadLine();
                    char mychar = Convert.ToChar(input);
                    return mychar;

                }
                catch
                {
                    Console.WriteLine("Please only use these Operators: (+),(-),(*),(/)");
                }

            }
        }
        public static double ReadFloat(string msg)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(msg);
                    string input = Console.ReadLine();
                    double mynumber = Convert.ToDouble(input);
                    return mynumber;
                }
                catch
                {
                    Console.WriteLine("Try a number!");
                }
            }
        }

        public static void Calculator()
        {
            Console.WriteLine("Welcome to my Calculator");
            double num1 = ReadFloat("Please enter the first Number: ");


            bool calcagain = true;

            while (calcagain)
            {



            }


        }

    }
}
