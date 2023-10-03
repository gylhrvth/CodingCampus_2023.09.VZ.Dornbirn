using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week01
{
    internal class PrintCharacters
    {
        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            PrintSquare('@', 10);
            Console.WriteLine();

            PrintTriangle('@', 10, 3);
            Console.WriteLine();

            PrintTriangleBottomLeft('@', 4);
            Console.WriteLine();

            PrintTriangleTopLeft('@', 5);
            Console.WriteLine();

            PrintTriangleTopRight('@', 5);
            Console.WriteLine() ;

            PrintTriangleBottomRight('@', 5);
            Console.WriteLine();

            PrintEmptySquare('@', 10);
            Console.WriteLine();

            PrintASquare('A', 3);
            Console.WriteLine();

            PrintSlash('y',4,false);
            Console.WriteLine();

            PrintTriangle('x', 1);
            Console.WriteLine();

            PrintRhombus('x', 11);
            Console.WriteLine();

            PrintX('x', 5); 
        }

        public static void PrintRealChars(char x, int anzahl)
        {
            for (int y = 0; y < anzahl; y++)
            {
                Console.Write(x); ///@@@@@@@@@
            }
        }


        /////Print Square

        public static void PrintSquare(char x, int anzahl)
        {

            for (int i = 0; i < anzahl; i++)
            {

                for (int y = 0; y < anzahl; y++)
                {
                    Console.Write(x);

                }

                Console.WriteLine();

            }

        }

        /////Print Trinangle
        public static void PrintTriangle(char x, int anzahl, int row)
        {

            for (int i = 0; i < row; i++)
            {

                for (int y = 0; y < anzahl; y++)
                {
                    Console.Write(x);
                }

                Console.WriteLine();
            }

        }

        ////Print Trinangle 1

        public static void PrintTriangleBottomLeft(char x, int anzahl)
        {

            for (int i = 0; i < anzahl; i++) ///anzahl = 4 // x = @
            {


                for (int y = 0; y < i; y++)
                {
                    Console.Write(x);
                }

                Console.WriteLine();
            }

        }

        ////Print Trinangle 2

        public static void PrintTriangleTopLeft(char x, int height) /* height = 5 */
        {

            for (int row = 0; row < height; row++)
            {
                //Console.WriteLine("Kobe Bryant" + row  + " Height: "+height+ "How many characters: "+(height  - row));
                PrintRealChars(x, height - row);
                Console.WriteLine();
            }

        }

        ///Print Trinangle 3

        public static void PrintTriangleTopRight(char x, int height) //height = 5
        {
            for (int row = 0; row < height; row++)
            {
                PrintRealChars('.', row);
                PrintRealChars(x, height - row);
                Console.WriteLine();
            }
        }

        //Print Trinangle 4

        public static void PrintTriangleBottomRight(char x, int height)
        {
            
            for(int row = 1; row <= height; row++)
            {
                PrintRealChars('.', height - row);
                PrintRealChars('@', row);
                Console.WriteLine();
            }

        }

        ///Print Empty Square

        public static void PrintEmptySquare(char x, int height)
        {
            PrintRealChars(x, height);

            Console.WriteLine();

            for (int row = 0; row < height - 2; ++row)
            {
                Console.Write(x);

                //spaces
                PrintRealChars('.',height - 2);
                

                Console.WriteLine(x);
            }

            PrintRealChars(x, height);
        }


        ///Print Empty Square("A")

        public static void PrintASquare(char x, int height)
        {
            PrintRealChars(x, height);

            Console.WriteLine();

            for (int row = 2; row < height; ++row)
            {
                Console.Write(x);

                //spaces
                PrintRealChars('.', 1);


                Console.Write(x);
                Console.WriteLine();
            }

            PrintRealChars(x, height);
        }

        public static void PrintSlash(char x, int height,bool slash)
        {
            if(slash)
            {
                for (int row = 0; row < height; row++)
                {
                    PrintRealChars('.', height - row -1);
                    Console.Write(x);

                    Console.WriteLine();
                }
            }
            else
            {
                ///Back Slash
                
                for(int i = 0; i < height; i++)
                {
                    PrintRealChars('.', i);
                    Console.WriteLine(x);

                    if(i == 0)
                    {
                        PrintRealChars('x',0);
                    }

                }


            }
        }

        public static void PrintTriangle(char x, int height) 
        {
            if(height == 1)
            {
                Console.WriteLine(x);
                return;
            }
     

            PrintRealChars('.',height);
            Console.WriteLine(x);

            for (int i = 1; i < height; i++)
            {


                    PrintRealChars('.', height - i);

                    PrintRealChars(x,1); /// x
                    PrintRealChars('.',i * 2 - 1); // space
                    PrintRealChars(x,1); /// x
                    Console.WriteLine();


            }

            PrintRealChars('x',height * 2 + 1);

        }


        public static void PrintRhombus(char x, int height)
        {
            height = height / 2;

            PrintRealChars('.', height);
            Console.WriteLine(x);

            for (int i = 1; i < height - 1; i++)
            {


                PrintRealChars('.', height - i);

                PrintRealChars(x, 1); /// x
                PrintRealChars(' ', i *  2 - 1); // space
                PrintRealChars(x, 1); /// x
                Console.WriteLine();
            }



            for (int i = 1; i < height; i++)
            {

                PrintRealChars('.', i);

                PrintRealChars(x, 1); /// x

                PrintRealChars('.', ((height - i) * 2) - 1); // space

                PrintRealChars(x, 1); /// x
                Console.WriteLine();
            }

            PrintRealChars('.', height);
            Console.WriteLine(x);

        }


        public static void PrintX(char x, int height)
        {



            for (int i = 1; i < height; i++)
            {

                PrintRealChars('.', i);

                PrintRealChars(x, 1); /// x

                PrintRealChars('.', ((height - i) * 2) - 1); // space

                PrintRealChars(x, 1); /// x


                Console.WriteLine();
            }

            for (int i = 2; i <= height -1; i++)
            {


                PrintRealChars('.', height - i);

                PrintRealChars(x, 1); /// x
                PrintRealChars(' ', i * 2 - 1); // space
                PrintRealChars(x, 1); /// x
                Console.WriteLine();
            }


        }

    }
}
