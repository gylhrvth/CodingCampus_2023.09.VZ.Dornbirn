using System;
namespace Lukas.Week03
{
	public class CommandLineInput
	{
        public static void Start()
        {
            //String input = Console.ReadLine();

            //Console.WriteLine("The input was: " + input);

            //int input = Console.Read();

            //Console.WriteLine("Input: " + input);

            //input = Console.Read();

            //Console.WriteLine("Input: " + input);

            //String input = Console.ReadLine();
            //Console.WriteLine("Input: " + input);

            //int ourNumber = Convert.ToInt32(input);
            //Console.WriteLine("Our number: " + ourNumber*3);

            int readNumber = ReadNumber("Please enter a number:", "Your number is bad. Please try again:");

            Console.WriteLine("Read number is: " + readNumber);
        }

        static int ReadNumber(String prompt, String onError)
        {
            Console.WriteLine(prompt);

            while (true)
            {
                try
                { 
                    String input = Console.ReadLine();
                    
                    int ourNumber = Convert.ToInt32(input);

                    return ourNumber;
                }
                catch (FormatException exc)
                {
                    //Console.Error.WriteLine(exc.StackTrace);
                    Console.Error.WriteLine(onError);
                }
            }
        }
    }
}

