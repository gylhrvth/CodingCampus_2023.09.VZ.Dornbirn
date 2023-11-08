using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Selbsttest.String_Manipulation
{
    public class String_Manipulation
    {
        public static void Start()
        {
            Auf1();
        }

        public static void Auf1()
        {
            string Word1 = "apfel";
            string Word2 = "regallager";
            string Word3 = "hanna";
            string Word4 = "reittier";

            if (Word1 == Convert.ToString(Word1.Reverse()))
            {
                Console.WriteLine(Word1 + " = " + "true");

            }
            else
            {
                Console.WriteLine(Word1 + " = " + "false");
            }
            if (Word2 == Word2)
            {
                Console.WriteLine(Word2 + " = " + "true");
            }
            else
            {
                Console.WriteLine(Word4 + " = " + "false");
            }
            if (Word3 == Convert.ToString(Word3.Reverse()))
            {
                Console.WriteLine(Word3 + " = true");
            }
            else
            {
                Console.WriteLine(Word3 + " = " + " false");
            }
            if (Word4 == Word4)
            {
                Console.WriteLine(Word4 + " = " + " true");
            }
            else
            {
                Console.WriteLine(Word4 + " = " + " false");
            }
                
        }
    }
}
