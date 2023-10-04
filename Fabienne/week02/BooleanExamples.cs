using System;

namespace Fabienne.week02
{
    public class BooleanExamples
    {
        public static void StartBooleanExamples()
        {
            bool isNumber = true;
            Console.WriteLine(isNumber);

            Console.WriteLine();

            bool isBig = false;
            Console.WriteLine(isBig);

            Console.WriteLine();

            Console.WriteLine("!false: " + !false);
            Console.WriteLine("!true: " + !true);

            Console.WriteLine();

            Console.WriteLine("true and true " + (true && true));
            Console.WriteLine("true and false " + (true && false));
            Console.WriteLine("false and true " + (false && true));
            Console.WriteLine("false and false " + (false && false));

            Console.WriteLine();

            Console.WriteLine("true or true " + (true || true));
            Console.WriteLine("true or false " + (true || false));
            Console.WriteLine("false or true " + (false || true));
            Console.WriteLine("false or false " + (false || false));

            Console.WriteLine();

            int i = 5;

            Console.WriteLine("i == 5: " + (i == 5));
            Console.WriteLine("i != 5: " + (i != 5));

            Console.WriteLine();

            Console.WriteLine("i < 5: " + (i < 7));
            Console.WriteLine("i > 5: " + (i > 7));

            Console.WriteLine();

            Console.WriteLine("i <= 5: " + (i <= 7));
            Console.WriteLine("i >= 5: " + (i >= 7));

            Console.WriteLine();

            int size = 7;
            for (int j = 0;  j < size; j++)
            {
                for (int k = 0; k < size; k++)
                {
                    if (j == k)
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }                
                }

                Console.WriteLine();
            }

        }
    }
}
