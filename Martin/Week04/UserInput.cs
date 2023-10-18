using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week04
{
    internal class UserInput
    {
        public static void Start()
        {
            string Name = AskName("Geben sie bitte ihren Name ein!");
            Console.WriteLine("Hallo {0}!",Name);

        }

        public static string AskName(string msg)
        {

            Console.WriteLine(msg);

            string line = "";
            string Name = Console.ReadLine();

            while(line.CompareTo("") == 0)
            {
                Console.WriteLine("Du hast nichts eingegeben");
                break;




                
            }

            return Name;
        }
    }
}
