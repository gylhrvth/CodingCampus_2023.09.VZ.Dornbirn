using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Week01
{
    public class Methoden
    {
        public static void Start()
        {
            Console.WriteLine("PrintAufgabe1");
            printChars("x", 10);
            Console.WriteLine();

            Console.WriteLine("PrintAufgabe2");
            printSquare("x", 10);
            Console.WriteLine();

            Console.WriteLine("PrintTriangleAufgabe2");
            printTriangle2("x", 10);
            Console.WriteLine();

            Console.WriteLine("PrintAufgabe2.1");
            printSquare2("x", 10);
            Console.WriteLine();

            Console.WriteLine("PrintTriangle1");
            printTriangle1("x", 10);
            Console.WriteLine();

        }

        public static void printChars(string symbol, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(symbol);
            }
        }

        public static void printSquare(string symbol, int count)
        {
            for (int i = 0; i < count * count; i++)
            {
                if (i % count == 0)
                {
                    Console.WriteLine();
                }
                Console.Write(symbol);
            }
        }

        public static void printTriangle2(string symbol, int count)
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine((new string('*', i)));
            }
            {
                
                {
                    Console.Write(symbol);
                }
                
            }
        }

        public static void printSquare2(string symbol, int count)
        {
            for(int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            
               

            



        public static void printTriangle1(string symbol, int count) { }
                }
    }
    
   
}

