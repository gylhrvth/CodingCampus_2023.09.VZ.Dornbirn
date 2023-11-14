using System;
namespace Mohammed.Week05
{
	public class CalculatorExp
	{
		public static double memory = 0.0;

		public static void Start()
		{
			double Result = ReadNum();
			while (true)
			{
				string op = ReadOp();
				double number = 0;
				if (IsOperatorBinary(op))
				{
					number = ReadNum();
				}
				Result = Calca(op, Result, number);
				Console.WriteLine(">>>{0}", Result);
			}

		}

		public static bool IsvalidOp(string operatorToTest)
		{
			string[] operators = new string[] { "+", "-", "*", "/", "M+", "M-", "MR", "MC", "sin" };

			foreach(string op in operators)
			{
				if(op == operatorToTest)
				{
					return true;
				}
			}
			return false;
		}

		public static bool IsOperatorBinary(string operatorToTest)
		{
			string[] binaryOperators = new string[] { "+", "-", "*", "/" };

			foreach(string op in binaryOperators)
			{
				if (op == operatorToTest)
				{
					return true;
				}
			}
			return false;
		}

		public static string ReadOp()
		{
			Console.Write("op:");

			string result = Console.ReadLine();

			while (!IsvalidOp(result))
			{
				Console.WriteLine("Operator is not known");
				Console.Write("op:");
				result = Console.ReadLine();
			}
			return result;
		}

		public static double ReadNum()
		{
			double result = double.MinValue;//

			while (result == double.MinValue)
			{
				Console.WriteLine(">>> ");

				string line = Console.ReadLine();

				try
				{
					result = Convert.ToDouble(line);
				}
				catch (FormatException)
				{
					Console.WriteLine("\"{0}\" ist keine gültige Zahl. ", line);

				}
				catch(OverflowException)
				{
					Console.WriteLine("\"{0}\" ist keine gültige zahl.", line);
				}
			}

			return result;
		}

		public static double Calca(string op, double number1, double number2)
		{
			if (op == "+") { return number1 + number2; }
			else if (op =="-") { return number1 + number2; }
			else if (op == "*") { return number1 + number2; }
			else if (op == "/") { return number1 + number2; }
            else if (op == "M+") { memory += number1; }
            else if (op == "M-") { memory -= number1; }
            else if (op == "MR") { return memory; }
            else if (op == "MC") { memory = 0.0; }
            else if (op == "sin") { return Math.Sin(number1); }

			return number1;

        }



    }
}

