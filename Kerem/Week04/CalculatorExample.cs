using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week04
{
    internal class CalculatorExample
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
                    Console.WriteLine("Please only operator like +, -, *, / or ^");
                }

            }

        }
        public static double Readfloat(string msg)
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
                    Console.WriteLine("That's not a number!");
                }
            }
        }
        public static void Calculator()
        {
            Console.WriteLine("Welcome to my Calculator!");
            double num1 = Readfloat("Enter your first number");

            bool end = false;
            while (!end)
            {
                char oprt = ReadChar("Enter which operator you wanna use +,-,*,/ or ^");
                double num2 = Readfloat("Enter your second number");
                double num2new = 1;

                if (oprt == '+')
                {
                    Console.WriteLine($"{num1}" + "+" + $"{num2}" + "=" + (num1 + num2));
                    double num3 = num1 + num2;
                    num1 = num3;
                    Console.WriteLine("Do you want to continue with the result?");

                    int weiter = ReadChar("y/n");
                    if (weiter != 'y')
                    {
                        end = true;
                    }
                }
                else if (oprt == '-')
                {
                    Console.WriteLine($"{num1}" + " - " + $"{num2}" + " = " + (num1 - num2));
                    double num3 = num1 - num2;
                    num1 = num3;
                    Console.WriteLine("Do you want to continue with the result?");

                    int weiter = ReadChar("y/n");
                    if (weiter != 'y')
                    {
                        end = true;
                    }
                }
                else if (oprt == '*')
                {
                    Console.WriteLine($"{num1}" + " * " + $"{num2}" + " = " + (num1 * num2));
                    double num3 = num1 * num2;
                    num1 = num3;
                    Console.WriteLine("Do you want to continue with the result?");

                    int weiter = ReadChar("y/n");
                    if (weiter != 'y')
                    {
                        end = true;
                    }
                }
                else if (oprt == '/')
                {
                    Console.WriteLine($"{num1}" + " / " + $"{num2}" + " = " + (num1 / num2));
                    double num3 = num1 / num2;
                    num1 = num3;
                    Console.WriteLine("Do you want to continue with the result?");

                    int weiter = ReadChar("y/n");
                    if (weiter != 'y')
                    {
                        end = true;
                    }
                }
                else
                {
                    for (double i = 0; i < num2; i++)
                    {
                        num2new = num1 * num2new;
                    }
                    Console.WriteLine($"{num1}" + " ^ " + $"{num2}" + " = " + (num2new));
                    num1 = num2new;
                    Console.WriteLine("Do you want to continue with the result?");

                    int weiter = ReadChar("y/n");
                    Console.WriteLine(num1);
                    if (weiter != 'y')
                    {
                        end = true;
                    }

                }
            }


        }
    }
}
