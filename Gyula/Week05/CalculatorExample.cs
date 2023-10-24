
using System;
namespace Gyula.Week05
{
	public class CalculatorExample
	{
		public static double memory = 0.0;

		public static bool IsValidOperator(string operatorToTest)
		{
			string[] operators = new string[] { "+", "-", "*", "/", "M+", "M-", "MR", "MC", "sin" };
			foreach (string op in operators)
			{
				if (op == operatorToTest)
				{
					return true;
				}
			}
			return false;
		}

        public static bool IsOperatorBinary(string operatorToTest)
        {
            string[] binaryOperators = new string[] { "+", "-", "*", "/" };
            foreach (string op in binaryOperators)
            {
                if (op == operatorToTest)
                {
                    return true;
                }
            }
            return false;
        }

        public static string ReadOperator()
		{
			Console.Write("op: ");
			string result = Console.ReadLine();

			while (!IsValidOperator(result))
			{
				Console.WriteLine("Operator is unknown...");
				Console.Write("op: ");
				result = Console.ReadLine();
            }
			return result;
		}

        public static double ReadNumber()
        {
            double result = Double.MinValue;
            while (result == Double.MinValue)
            {
                Console.Write(">>> ");
                string line = Console.ReadLine();
                try
                {
					result = Convert.ToDouble(line);
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("\"{0}\" ist keine gültige Zahl.", line);
                }
				catch (OverflowException ofe)
				{
                    Console.WriteLine("\"{0}\" ist keine gültige Zahl.", line);
                }
            }

            return result;
        }



		public static double Calc(string op, double num1, double num2)
		{
			if (op == "+") { return num1 + num2; }
			else if (op == "-") { return num1 - num2; }
			else if (op == "*") { return num1 * num2; }
			else if (op == "/") { return num1 / num2; }
			else if (op == "M+") { memory += num1; }
			else if (op == "M-") { memory -= num1; }
			else if (op == "MR") { return memory; }
			else if (op == "MC") { memory = 0.0; }
			else if (op == "sin") { return Math.Sin(num1); }

            return num1;
		}

        public static void Start()
		{
			double partResult = ReadNumber();
			while (true)
			{
                string op = ReadOperator();
				double num = 0.0;
				if (IsOperatorBinary(op))
				{
					num = ReadNumber();
				}
				partResult = Calc(op, partResult, num);
				Console.WriteLine(">>> {0}", partResult);
            }
        }
	}
}

