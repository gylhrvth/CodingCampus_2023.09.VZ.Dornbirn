using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Selbsttest_Strukto
{
    internal class StringManipulation
    {
        public static void Start()
        {
            //Aufgabe 1)
            Console.WriteLine("Aufgabe 1: \n");
            Console.WriteLine("Apfel = " + Palindrom("Apfel"));
            Console.WriteLine("Regallager = " + Palindrom("Regallager"));
            Console.WriteLine("Hanna = " + Palindrom("Hanna"));
            Console.WriteLine("Reittier = " + Palindrom("Reittier"));
            Console.WriteLine("==========================");

            //Aufgabe 2)
            Console.WriteLine("Aufgabe 2: \n");
            Console.WriteLine("==========================");

        }

        //Aufgabe 1:
        public static bool Palindrom(string str)
        {
            bool palindrom = true;
            str =str.ToUpper();
            char[] chars = str.ToCharArray();
            for (int i = 0; i < (chars.Length) / 2; i++)
            {
                if (chars[i] == chars[chars.Length - 1 - i])
                {
                }
                else
                {
                    palindrom = false;
                }
            }
            return palindrom;
        }

        //-----------------------------------------------------------------------------------------------------------


        //Aufgabe 2:

    }
}
