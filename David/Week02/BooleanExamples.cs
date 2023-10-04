using System;
namespace David.Week02
{
    public class BooleanExamples
    {
        public static void StartBooleanExamples()
        {
            bool isNumber = true;
            Console.WriteLine(isNumber);

            bool isBig = false;
            Console.WriteLine(isBig);

            Console.WriteLine();

            Console.WriteLine("!false : " + !false);
            Console.WriteLine("!true : " + !true);

            Console.WriteLine();

            Console.WriteLine("true and true " + (true && true));
            Console.WriteLine("true and false " + (true && false));
            Console.WriteLine("false and true " + (false && true));
            Console.WriteLine("false and false " + (false && false));

            Console.WriteLine();

            Console.WriteLine("true or false " + (true || false));
            Console.WriteLine("true or true " + (true || true));
            Console.WriteLine("false or true " + (false || true));
            Console.WriteLine("false or false " + (false || false));

            Console.WriteLine();

            int iX = 5;
            Console.WriteLine("i == 5: " + (iX == 5));
            Console.WriteLine("i != 5: " + (iX != 5));
            Console.WriteLine("i <  7: " + (iX < 7));
            Console.WriteLine("i <= 7: " + (iX <= 7));
            Console.WriteLine("i >  7: " + (iX > 7));
            Console.WriteLine("i >= 7: " + (iX >= 7));

            Console.WriteLine();



            Console.WriteLine("Aufgabe Print Slash");
            printSlash("x", 3, true);

            Console.WriteLine("---------");

            Console.WriteLine("Aufgabe Print Pyramid");
            printPyramid("x", 10);

            Console.WriteLine("------");

            Console.WriteLine("printRhombus");
            printRhombus("x", 7);
        }

        public static void printSlash(String symbol, int count, bool cas)
        {
            if (cas == true)
            {
                for (int i = 0; i < count; i++)
                {
                    for (int y = 0; y < count; y++)

                    {
                        if (i == y)
                        {
                            Console.Write(symbol);
                        }
                        else
                        {
                            Console.Write(" ");

                        }
                    }
                    Console.WriteLine();
                }
            }

            else
            {
                count = 4;
                symbol = "y";

                for (int i = 0; i < count; i++)
                {
                    for (int y = 0; y < count + 1; y++)
                    {
                        if ( y == count - i)
                        {
                            Console.Write(symbol);
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
        public static void printPyramid(String symbol, int count)
        {
            for (int row = 0; row < count; row++)
            {
                for (int col = 0; col < count * 2 - 1; col++)
                {
                    if (row + col == count - 1)
                    {
                        Console.Write(symbol);
                    }
                    else if (row - 1 + count == col)
                    {
                        Console.Write("o");
                    }
                    else if (row == count - 1)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(".");
                    }
                    
                }
                Console.WriteLine();
            }
        }

        public static void printRhombus(String symbol, int count)
        {
            for (int row = 0; row < count; row++)
            {
                for (int col = 0; col < count; col++)
                {
                    if (col == row + count)
                    {
                        Console.Write("o");
                    }
                
                    else
                    {
                        Console.Write(".");
                    }
                    
                }

                Console.WriteLine();
            }
        }
    }
}

