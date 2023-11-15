using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Exercises
{
    internal class Methods_Loops
    {
        public static void Start()
        {
            Console.WriteLine("PrintCharacters");
            printcharacters("x", 10);
            Console.WriteLine();

            Console.WriteLine("PrintSquare");
            printsquare("x", 10);
            Console.WriteLine();

            Console.WriteLine("PrintRect");
            printrect("x", 10, 3);
            Console.WriteLine();

            Console.WriteLine("PrintTrinangle");
            printTrinangle("x", 4);
            Console.WriteLine();

            Console.WriteLine("PrintTrinangle2");
            printTrinangle2("x", 5);
            Console.WriteLine();


        }
        public static void printcharacters(string symbol, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(symbol);
            }
        }
        public static void printsquare(string symbol, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(symbol);

                }
                Console.WriteLine();
            }
        }
        public static void printrect(string symbol, int size, int row)
        {
            for(int i = 0;i < row; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
        public static void printTrinangle(string symbol, int row)
        {
            for(int i = 1; i <= row; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(symbol);

                }                 
                
                Console.WriteLine();
            }
        }
        public static void printTrinangle2(string symbol, int row)
        {
            for(int i = 0; i < row ; i++)
            {
                for(int j = row ; j > i ; j--)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }

    }
}
