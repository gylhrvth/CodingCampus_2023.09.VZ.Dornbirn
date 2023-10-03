using System;

namespace Fabian.Week02
{
    public class BooleanExamples
    {
        public static void StartBooleanExamples()
        {
            
            bool isNumber = true;
            Console.WriteLine(isNumber);

            bool isBig = false;
            Console.WriteLine(isBig);

            Console.WriteLine($"!false : {!false}");
            Console.WriteLine($"!true : {!true}");
            Console.WriteLine();

            Console.WriteLine($"true and false  : {true && true}");
            Console.WriteLine($"false and true  : {false && true}");
            Console.WriteLine($"false and true  : {false && true}");
            Console.WriteLine($"false and false : {false && false}");
            Console.WriteLine();

            Console.WriteLine($"true and false  : {true || true}");
            Console.WriteLine($"false and true  : {false || true}");
            Console.WriteLine($"false and true  : {false || true}");
            Console.WriteLine($"false and false : {false || false}");
            Console.WriteLine();

            int iX = 5;
            Console.WriteLine($"i == 5 {iX == 5}");
            Console.WriteLine($"i != 5 {iX != 5}");
            Console.WriteLine($"i < 7 {iX < 7}");
            Console.WriteLine($"i <= 7 {iX <= 7}");
            Console.WriteLine($"i > 7 {iX > 7}");
            Console.WriteLine($"i >= 7 {iX >= 7}");
            Console.WriteLine();

            int size = 7;

            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    if(i == j)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
