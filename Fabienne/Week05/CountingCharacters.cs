using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Fabienne.Week05
{
    internal class CountingCharacters
    {
        public static void Start()
        {
            String s = Ressources.StringRessources.getText();
            Console.WriteLine(s);
            int[] counting = CountCharacters(s);

            PrintCountCharacters(counting);
        }
        public static int[] CountCharacters(String s)
        {
            int[] counting = new int[char.MaxValue];

            for (int i = 0; i < s.Length; i++)
            {
                char abc = s[i];

                ++counting[abc];
            }

            return counting;
        }
        public static void PrintCountCharacters(int[] counting)
        {
            for (int i = 0; i < counting.Length; ++i)
            {
                if (counting[i] > 0)    
                {
                    char abc = (char)i;

                    Console.WriteLine(abc + " " + counting[i]);
                }
            }
        }       
    }
}
