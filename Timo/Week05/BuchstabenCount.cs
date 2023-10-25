using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week05
{
    internal class BuchstabenCount
    {
        public static void Start()
        {
            PrintResult(CountLetters(Ressources.StringRessources.getText()));
        }

        public static int[] CountLetters(string text)
        {
            int[] count = new int[char.MaxValue];
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                count[c]++;
            }

            return count;
        }

        public static void PrintResult(int[] count)
        {
            for (int i = 0; i < count.Length; ++i)
            {
                if (count[i] > 0)
                {
                    char c = (char)i;
                    Console.WriteLine(c + ": " + count[i]);
                }
            }
        }
    }
}
