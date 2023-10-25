using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ressources;
using static Kerem.Week05.StringExamples;

namespace Kerem.Week05
{
    internal class StringExamples2
    {
        public static void Start()
        {

            //String[] names = new String[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };
            //string s = String.Join(" ", names);
            //Console.WriteLine(names);

            String t = StringRessources.getText();
            Console.WriteLine(t);

            int[] count = countLetters(t);
            PrintResult(count);
        }
        public static void PrintResult(int[] count)
        {
            for (int i = 0; i < count.Length; ++i)
            {
                if (count[i] > 0)
                {
                    char c = (char)i;
                    Console.WriteLine(c + " " + count[i]);
                }
            }
        }
        public static int[] countLetters(string text)
        {
            int[] count = new int[char.MaxValue];
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                ++count[c];
            }
            return count;
        }
    }
}
