using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week04
{
    internal class ConsoleInput
    {
        public static void Start()
        {
            //Console.WriteLine("Read string");
            //string userinput = ReadString("Enter a String");
            //Console.WriteLine("Userinput was: " + userinput);


            //Console.WriteLine("Read Number");
            //int userinputnumber = ReadNumber("Enter a number", "Please only numbers! Try again!");
            //Console.WriteLine("Userinput was: " + userinputnumber);
            Console.WriteLine("Welcome to my super duper Guessgame");



        }
        public static string ReadString(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return input;
        }
        public static int ReadNumber(string prompt, string error)
        {
            Console.WriteLine(prompt);

            while (true)
            {
                try
                {
                    string input = Console.ReadLine(); 
                    int output = Convert.ToInt32(input);
                    return output;
                    
                }
                catch
                {
                    Console.WriteLine(error);
                }
            }
        }
        public static void Guessgame()
        {
            int num = new Random().Next(101);
            int guess = 0;

            while(num!= guess)
            {
                try
                {

                    Console.WriteLine("Enter a number between 100 and 1!!");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if(guess > 100 || guess < 1)
                    {
                        Console.WriteLine("Functionable only between 100 and 1!!");
                    }
                    else if(guess == num)
                    {
                        Console.WriteLine("Good job jackass!");
                    }
                    else if(guess > num)
                    {
                        Console.WriteLine($"{guess}Your number is too high!!");
                    }
                    else if(guess < num)
                    {
                        Console.WriteLine($"{guess}Your number is too low!!");
                    }
                    
                }
                catch
                {
                    Console.WriteLine("Only Numbers!");
                }
            }
        }
    }
}
