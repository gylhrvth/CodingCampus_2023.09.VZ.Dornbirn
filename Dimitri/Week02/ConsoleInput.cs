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

            Console.Write("Your string is: " + ReadString());
        }

        public static string ReadString()
        {
            string UserInput = "";
            while (UserInput == String.Empty || UserInput == null)
            {
                Console.WriteLine("Enter a string and confirm your input with enter:");

                UserInput = Console.ReadLine();

                if (UserInput == String.Empty || UserInput == null)
                {
                    UserInput = "You have entered an empty string";
                }

                Console.WriteLine("Enter a new string:");
            }

                return UserInput;
        }
    }
}
