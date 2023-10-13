using System;
using System.Collections.Generic;
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

            int readRandomNumber = ReadRandomNumber("Las uns ein Spiel spielen ö_ö , tippe einen Zahl ein :_[", " Versuchs doch mit einem Zahl: ", "höher: ", "runter: ", "Richtig !!!");


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




    }
}
