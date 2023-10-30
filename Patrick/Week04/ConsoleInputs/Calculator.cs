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
            //AUFGABE 1 Taschenrechner 
            //Console.WriteLine("The result = " + Calculations());
            //float result = Calculations();

            //AUFGABE 2 Taschenrechner extended
            //CalculatorExtended();

            //AUFGABE 3 Taschenrechner weiterrechnen
            //CalculationsResult(Calculations());

            //AUFGABE 4 Taschenrechner mit Memory Funktion         
            CalculatorAdvanced();
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

            float result = 0;

            Console.Write("Please enter a Number: >>>>>  ");
            float inputNumber1 = ReadNumber();

            Console.Write("Please enter a Operator: +, -, *, / >>>>>>  ");
            string math = ReadOperator();

            Console.Write("Please enter a Number again: >>>>>  ");
            float inputNumber2 = ReadNumber();
            Console.WriteLine("===============================================");

            if (math == "+")
            {
                result = inputNumber1 + inputNumber2;
                Console.WriteLine("The result =  " + result);
            }

            else if (math == "-")
            {
                result = inputNumber1 - inputNumber2;
                Console.WriteLine("The result =  " + result);
            }
            else if (math == "*")
            {
                result = inputNumber1 * inputNumber2;
                Console.WriteLine("The result =  " + result);
            }

            else if (math == "/")
            {
                result = inputNumber1 / inputNumber2;
                Console.WriteLine("The result =  " + result);
            }
            return result;
        }

        public static void CalculationsResult(float result)
        {
            float resultNew = result;
            while (true)
            {               
                Console.WriteLine(" Your interim result = " + result);
                Console.Write("Please enter a Operator: +, -, *, / >>>>>>  ");
                string math = ReadOperator();

                Console.Write("Please enter a Number again: >>>>>  ");
                float inputNumber2 = ReadNumber();
                Console.WriteLine("===============================================");

                if (math == "+")
                {
                    resultNew += inputNumber2;
                    Console.WriteLine("The result =  " + result);
                    break;
                }

                else if (math == "-")
                {
                    result -= inputNumber2;
                    Console.WriteLine("The result =  " + result);
                    break;
                }
                else if (math == "*")
                {
                    result *= inputNumber2;
                    Console.WriteLine("The result =  " + result);
                    break;
                }

                else if (math == "/")
                {
                    result /= inputNumber2;
                    Console.WriteLine("The result =  " + result);        
                    break;
                }                
            }
            //return resultNew;
        }


        public static void CalculatorExtended()
        {
            while (true)
            {                
                Console.WriteLine("Do you want to calculate again? Tip \"yes\" or \"no\"");

                if (StringReadYesOrNo() == false)
                {
                    break;
                }

                Console.WriteLine("===============================================");
                Console.WriteLine("===============================================");

            }
        }

        public static float CalculatorAdvanced()
        {
            float resultNew = 0;
            float result = Calculations();
            
            while (true)
            {
                Console.WriteLine("Do you want a interim result? ");

                if (StringReadYesOrNo() == false)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("===============================================");
                    Console.WriteLine("===============================================");
                    CalculationsResult(result);                    
                }
            }
            return resultNew;
        }
    }
}
