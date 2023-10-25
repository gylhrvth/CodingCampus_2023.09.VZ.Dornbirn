using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ressources;

namespace Simon.Week05
{
    internal class Buchstaben_Zählen
    {
        public static void Start()
        {
            String s = StringRessources.getText();
            Console.WriteLine(s);

            Console.WriteLine("ammount of Letters");
            int[] count = countLetters(s);
            PrintResult(count);

        }
        //Aufgabe Buchstaben zählen
        public static void PrintResult(int[] count)
        {
            for (int i = 0; i < count.Length;i++)
            {
                if (count[i] > 0)
                {
                    char c = (char)i;
                    Console.WriteLine("{0} {1}", c, count[i]);
                }
                
            }
        }

        public static int[] countLetters(string input)
        {
            int[] count = new int[char.MaxValue];
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                ++count[c];
            }

            return count;

        }
        

    }
}
