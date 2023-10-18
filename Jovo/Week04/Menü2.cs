using Jovo.Week01;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Jovo.Week01.Methoden;



namespace Jovo.Week04
{
    public class Menü2
    {

        public static void Start()
        {




            ReadNumberMenue("Welcome!", "Was soll ich dir zeichnen", "Christbaum", "Quader", "Rhombus", "Wie groß soll es sein?", "welche symbole soll ich benutzen");
        }







        public static int ReadNumberMenue(String stage1, String Question, String drawing1, String drawing2, String drawing3, String asksize, String asksymbol)
        {
            Console.WriteLine(stage1);
            Console.WriteLine("==================");
            Console.WriteLine(Question);
            Console.WriteLine("==================");
            Console.WriteLine("1 für = " + drawing1);
            Console.WriteLine("2 für = " + drawing2);
            Console.WriteLine("3 für = " + drawing3);
            Console.WriteLine("==================");




            while (true) 
            {
                try
                {
                    String input = Console.ReadLine();
                    int myNumber = Convert.ToInt32(input);


                    if (myNumber == 1)
                    {
                        Console.WriteLine(asksize);
                        Console.WriteLine("==================");


                        String sizeinput = Console.ReadLine();
                        int size = Convert.ToInt32(sizeinput);
                        int sizeofDrawing = size;
                        Console.WriteLine("==================");

                        Console.WriteLine(asksymbol);
                        String symbol = Console.ReadLine();
                        String symbolofDrawing = symbol;

                        Methoden.PrintChristmasTree(sizeofDrawing, symbolofDrawing);

                        Console.WriteLine("Nochmal?");
                        Console.WriteLine("1 für ja");
                        Console.WriteLine("2 für nein");


                        int myNumber2 = Convert.ToInt32(input);



                       /* if (myNumber2 == 2)
                        {
                            ReadNumberMenue(stage2, Question, drawing1, drawing2, drawing3, asksize, asksymbol);
                        }*/


                    }


                     if (myNumber == 2)
                     {
                        Console.WriteLine(asksize);
                        Console.WriteLine("=======================");

                        String sizeinput = Console.ReadLine();
                        int size = Convert.ToInt32(sizeinput);
                        int sizeofDrawing = size;
                        Console.WriteLine("=========================");

                        Console.WriteLine(asksymbol);
                        String symbol = Console.ReadLine();
                        String symbolofDrawing = symbol;

                        Methoden.PrintEmptySquare(symbolofDrawing, sizeofDrawing);



                    
                     }



                     if (myNumber == 3)
                    {
                        Console.WriteLine(asksize);
                        Console.WriteLine("===================");

                        String sizeinput = Console.ReadLine();
                        int size = Convert.ToInt32(sizeinput);
                        int sizeofDrawing = size;
                        Console.WriteLine("===================");

                        Console.WriteLine(asksymbol);
                        String symbol = Console.ReadLine();
                        String symbolofDrawing = symbol;

                        Methoden.PrintMeinTest6(symbolofDrawing, sizeofDrawing);

                    }

                    
                     
                }


                catch
                {

                }

            }


        }


    }
}
