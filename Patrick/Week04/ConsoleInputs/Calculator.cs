using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Patrick.Week04.ConsoleInputs.ConsoleInput;

namespace Patrick.Week04.ConsoleInputs
{
    internal class Calculator
    {
        public static void Start()
        {
            //Console.WriteLine("The result = " + Calculators());
            float result = Calculations();

            CalculatorExtended(result);
        }


        public static float ReadNumber()
        {
            while (true)
            {
                string line = Console.ReadLine();
                try
                {
                    float result = float.Parse(line);
                    return result;

                }
                catch (FormatException)
                {
                    Console.WriteLine("This is no Number, try again!");
                    Console.Write("Please enter a Number: >>>>>  ");
                }
            }
        }


        public static string ReadOperator()
        {

            while (true)
            {
                string math = Console.ReadLine();

                if (math == "*" || math == "+" || math == "-" || math == "/")
                {
                    return math;
                }
                else
                {
                    Console.WriteLine("This is no correkt operator, try Again!");
                    Console.Write("Please enter a Operator: +, -, *, / >>>>>>  ");
                }
            }
        }


        public static float Calculations()
        {
            while (true)
            {
                float result = 0;

                Console.Write("Please enter a Number: >>>>>  ");
                float inputNumber1 = ReadNumber();

                Console.Write("Please enter a Operator: +, -, *, / >>>>>>  ");
                string math = ReadOperator();

                Console.Write("Please enter a Number again: >>>>>  ");
                float inputNumber2 = ReadNumber();
                Console.WriteLine("===============================================");
                Console.WriteLine("===============================================");

                if (math == "+")
                {
                    result = inputNumber1 + inputNumber2;
                    return result;
                }

                else if (math == "-")
                {
                    result = inputNumber1 - inputNumber2;
                    return result;
                }
                else if (math == "*")
                {
                    result = inputNumber1 * inputNumber2;
                    return result;
                }

                else if (math == "/")
                {
                    result = inputNumber1 / inputNumber2;
                    return result;
                }
            }
        }

        public static void CalculatorExtended(float result)
        {
            while (StringReadYesOrNo() == true)
            {
                Console.WriteLine("The result =  " + result);
                Console.WriteLine("===============================================");
                Console.WriteLine("===============================================");
                Console.WriteLine("Do you want to calculate again? Tip \"yes\" or \"no\"");

            }
        }
    }
}
