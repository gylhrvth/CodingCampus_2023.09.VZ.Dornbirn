using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Riccardo.Week04
{
    internal class UserInputExample
    {
        public static void Start()
        {
            //string name = ReadPerson("Bitte geben Sie ihren Vornamen ein: ");
            //Console.WriteLine(name);

            int number = ReadNumber("Bitte gib eine Zahl ein: ", 0, 100);
            Console.WriteLine(number);
        }

        public static string ReadPerson(string msg)
        {
            string line = "";
            bool firstTry = true;
            if (firstTry)
            {
                Console.Write(msg);
                line = Console.ReadLine();
                firstTry = false;
            }
            return line;


        }

        public static int ReadNumber(string msg, int minValid, int maxValid)
        {
            int result = Int32.Min(minValid, maxValid);
            int line = 0;
            bool firstTry = true;

            while (firstTry == true)
            {
                Console.Write("{0} zwischen {1} und {2}: ", msg, minValid, maxValid);
                line = int.Parse(Console.ReadLine());
                firstTry = false;
            }
            return line;
        }
    }
}
