using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week04
{
    internal class Input
    {
        public static void Start()
        {

            //String input = Console.ReadLine();
            //Console.WriteLine("your input is: " + input);


            //int input = Console.Read();
            //Console.WriteLine("your input is: " + input);


            //int readNumber = ReadNumbner("Enter a Numero:", " EROR 404 : Try again : ");

            //int readRandomNumber = ReadRandomNumber("Lass uns ein Spiel spielen ö_ö , tippe einen Zahl ein :_[", " Versuchs doch mit einem Zahl: ", "höher: ", "runter: ", "Richtig !!!");
            
                    int readNumberMenue = ReadNumberMenue("Ola Willkomen!", "was soll ich dir zeichnen?", "Christbaum", "Quader", "Rhombus", "Wie groß soll es sein?", "und welches Symbol soll es haben?");

        
        }

        public static Random rand = new Random();
        static int ReadNumbner(String yes, String no)
        {
            Console.WriteLine(yes);
            while (true)
            {
                try
                {
                    String input = Console.ReadLine();
                    int myNumber = Convert.ToInt32(input);
                    return myNumber;
                }
                catch
                {
                    Console.Error.WriteLine(no);
                }
            }
        }


        static int ReadRandomNumber(String Stage1,String error ,String higher, String lower, String correct)
        {
            Console.WriteLine(Stage1);
            int random = rand.Next(101);
            int answer = random;
            bool start = true;
            while (true)
            {
                try
                {
                    String input = Console.ReadLine();
                    int myNumber = Convert.ToInt32(input);
                    if (answer < myNumber)
                    {
                        Console.WriteLine();
                        Console.WriteLine(lower);
                        Console.WriteLine("<--" + myNumber);
                        Console.WriteLine();
                    }
                    else if (answer > myNumber)
                    {
                        Console.WriteLine();
                        Console.WriteLine(higher);
                        Console.WriteLine(myNumber + "-->");
                        Console.WriteLine();
                    }
                    else if (answer == myNumber)
                    {
                        Console.WriteLine();
                        Console.WriteLine(answer + " " + correct);
                        Console.WriteLine();
                        return answer;
                    }                           
                }
                catch
                {
                    Console.Error.WriteLine(error);
                }
            }
        }

        static int ReadNumberMenue(String stage1, String questionDrawing, String drawing1, String drawing2, String drawing3, String asksize, String asksymbol)
        {
            Console.WriteLine(stage1);
            Console.WriteLine(questionDrawing);
            Console.WriteLine("1 für = " + drawing1);
            Console.WriteLine("2 für = " + drawing2);
            Console.WriteLine("3 für = " + drawing3);
            Console.WriteLine();
           
            string stage2 = " ";
            


            while (true) 
            {
                try
                {
                    String input = Console.ReadLine();
                    int myNumber = Convert.ToInt32(input);
                    

                    if (myNumber == 1)
                    {
                        
                        Console.WriteLine(asksize);
                        String inputsize = Console.ReadLine();
                        int size = Convert.ToInt32(inputsize);
                        int sizeOfDrawing = size;

                        Console.WriteLine(asksymbol);
                        String symbol = Console.ReadLine();
                        String symbolofDrawing = symbol;
                      
                        Mehmet.Week02.BooleanExamples.PrintChristmasTree(sizeOfDrawing, symbolofDrawing);
                       

                        Console.WriteLine("Nochmal?");
                        Console.WriteLine("1 für  ja");
                        Console.WriteLine("2 für nein");

                        
                        int myNumber2 = Convert.ToInt32(input);
                        

                        if (myNumber2  == 2)
                        {
                            ReadNumberMenue(stage2, questionDrawing, drawing1, drawing2, drawing3, asksize, asksymbol);
                        }
                        else
                        {
                            return 18437501;
                        }





                    }



                }
                catch
                {
                    
                }
            }
        }







        //public static void PrintChristmasTree(int size,String symbol)
        //{
        //    for (int x = 0; x < size; x++)
        //    {
        //        {
        //            for (int y = size - 1; y > x; y--)
        //            {
        //                Console.Write(" ");
        //            }
        //            for (int z = -1; z < x; z++)
        //            {
        //                Console.Write(symbol);
        //            }
        //            for (int z = 0; z < x; z++)
        //            {
        //                Console.Write(symbol);
        //            }
        //            for (int y = size; y > x; y--)
        //            {
        //                Console.Write(" ");
        //            }
        //        }
        //        Console.WriteLine();
        //    }
        //    for (int y = 0; y < size; ++y)
        //    {
        //        Console.Write(symbol);
        //        Console.Write(" ");
        //    }
        //    Console.WriteLine();
        //    for (int y = 0; y < size / 4; ++y)
        //    {
        //        for (int x1 = 0; x1 < size - 3; ++x1)
        //        {
        //            Console.Write(" ");
        //        }
        //        for (int x2 = 0; x2 < size - 4; ++x2)
        //        {
        //            Console.Write(symbol);
        //        }
        //        for (int x3 = 0; x3 < size - 3; ++x3)
        //        {
        //            Console.Write(" ");
        //        }
        //        Console.WriteLine();
        //    }
        //}


    }
}
