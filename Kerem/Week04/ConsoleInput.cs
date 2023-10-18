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
            Console.WriteLine("Read string");
            string userinput = ReadString("Enter a String");
            Console.WriteLine("Userinput was: " + userinput);


            Console.WriteLine("Read Number");
            int userinputnumber = ReadNumber("Enter a number", "Please only numbers! Try again!");
            Console.WriteLine("Userinput was: " + userinputnumber);



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
    }
}
