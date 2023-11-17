using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Niklas.Week07.Selbsttest
{
    internal class StringManipulation
    {
        public static void Start()
        {
            Reverse();
        }
        public static void Reverse()
        {
            string Word1 = "apfel";
            string Word2 = "regallager";
            string Word3 = "hanna";
            string Word4 = "reittier";

            char[] charArray = Word1.ToCharArray();
            System.Array.Reverse(charArray);
            string output = new string(charArray);
            Console.Write(Word1 + " = ");
            Console.WriteLine(Regex.IsMatch(output, Word1));

            char[] charArray2 = Word2.ToCharArray();
            System.Array.Reverse(charArray2);
            string output2 = new string(charArray2);
            Console.Write(Word2 + " = ");
            Console.WriteLine(Regex.IsMatch(output2, Word2));

            char[] charArray3 = Word3.ToCharArray();
            System.Array.Reverse(charArray3);
            string output3 = new string(charArray3);
            Console.Write(Word3 + " = ");
            Console.WriteLine(Regex.IsMatch(output3, Word3));

            char[] charArray4 = Word4.ToCharArray();
            System.Array.Reverse(charArray4);
            string output4 = new string(charArray4);
            Console.Write(Word4 + " = ");
            Console.WriteLine(Regex.IsMatch(output4, Word4));
        }
    }
}
