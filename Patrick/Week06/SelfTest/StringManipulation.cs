using Ressources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week06.SelfTest
{
    internal class StringManipulation
    {
        public static void Start()
        {
            //Aufgabe1
            string Word1 = "apfel";
            string Word2 = "regallager";
            string Word3 = "hanna";
            string Word4 = "reittier";

            Console.WriteLine($"{Word1, -10} = " + Palindrom(Word1));
            Console.WriteLine($"{Word2} = " + Palindrom(Word2));
            Console.WriteLine($"{Word3, -10} = " + Palindrom(Word3));
            Console.WriteLine($"{Word4,-10} = " + Palindrom(Word4));

            //Aufgabe2
            String hesse = StringRessources.getHesse();
            hesse = hesse
                .Replace("(", "")
                .Replace(")", "")
                .Replace(".", "")
                .Replace("-", "");
            Console.WriteLine(hesse);
            string[] words = hesse.Split(' ');
            string longestWord = "";           
            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
            Console.WriteLine($"Longest word: {longestWord}");
        }

        public static string Palindrom(string word)
        {
            Console.WriteLine();
            Console.WriteLine(word);
            char[] chars = word.ToCharArray();
            string a = "true";
            string b = "false";
            for (int i = 0; i < chars.Length / 2; i++)
            {
                char tempMemory = chars[i];
                chars[i] = chars[chars.Length - 1 - i];
                chars[chars.Length - 1 - i] = tempMemory;
            }
            Console.WriteLine("{0}", string.Join(", ", chars));
            string wordReverse = new string(chars);

            if (wordReverse != word)
            {
                return b;
            }
            else
            {
                return a;
            }
        }




    }
}
