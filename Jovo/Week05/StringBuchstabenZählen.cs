using Ressources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week05
{
    internal class StringBuchstabenZählen
    {
        public static void Start()
        {

            string s = StringRessources.getText();
            Console.WriteLine(s);

            int[] count = countLetters(s);
            PrintResult(count);
        }



        public static void PrintResult(int[] count)
        {
            for ( int i = 0; i < count.Length; i++ )
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
            for ( int i = 0;i < text.Length;i++ )
            {
                char c = text[i];
                ++count[c];
            }
            return count;
        }
    }
}
