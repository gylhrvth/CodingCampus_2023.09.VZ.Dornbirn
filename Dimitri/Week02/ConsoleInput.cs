using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dimitri.Week02
{
    internal class ConsoleInput
    {
        public static void Main()
        {

            //Console.Write("Your string is: " + ReadString());
            Console.Write("Your int is: " + ReadInt());

        }

        public static string ReadString()
        {

            Console.WriteLine("Enter a string and confirm your input with enter:");

            string UserInput = Console.ReadLine();


            return UserInput;
        }

        public static int ReadInt()
        {
            int UserInput;

            Console.WriteLine("Enter a int and confirm your input with enter:");

            string intTmp = Console.ReadLine();

            bool IsAllDigits = false;

            while (IsAllDigits)
            {
                foreach (char c in intTmp)
                {
                    if (!char.IsDigit(c))
                    {
                        IsAllDigits = false;
                    }
                }


            Console.WriteLine("Enter a int and confirm your input with enter:");

            intTmp = Console.ReadLine();

            }
            IsAllDigits = true;


            while (!IsAllDigits)


            UserInput = Convert.ToInt32(intTmp);

            return UserInput;
        }
    }
}
