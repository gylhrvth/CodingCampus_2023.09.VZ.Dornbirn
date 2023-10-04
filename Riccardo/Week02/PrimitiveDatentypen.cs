using System;
using System.Linq.Expressions;

namespace Riccardo.Week02
{
    public class PrimitiveDatentypen
    {
        public static void Start()
        {
            StartBooleanExamples("x", 7);
        }
        public static void StartBooleanExamples(string symbol, int size)
        {

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (col == row)
                    {
                        Console.Write(symbol);
                    }
                    else if ()
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



    }
}



