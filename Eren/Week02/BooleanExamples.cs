using System;
namespace Eren.Week02
{
    public class BooleanExamples
    {
        public static void StartBooleanExamples()
        {
           
            Console.WriteLine();



            Console.WriteLine("Aufgabe Print Slash");
            printSlash("x", 3, true);

           
            printPyramid("x", 10);

            Console.WriteLine("------");

           
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
            Console.WriteLine("---------");

            Console.WriteLine("Aufgabe Print Pyramid");

            for (int row = 0; row < count; row++)
            {
                for (int col = 0; col < count * 2 - 1; col++)
                {
                    if (row + col == count - 1)
                    {
                        Console.Write("X ");
                    }
                    else if (row - 1 + count == col)
                    {
                        Console.Write("Y");
                    }
                    else if (row == count)
                    {
                        Console.WriteLine("Z ");
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


