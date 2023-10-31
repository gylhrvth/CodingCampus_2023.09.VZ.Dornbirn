using Ressources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week05
{
    internal class Example
    {
        public static void Start()
        {
            String text = StringRessources.getHesse();
            Console.WriteLine(text);
            Console.WriteLine("Count \"Hess\" int text: {0}",CountSubtring(text,"Hesse"));
        }

        public static int CountSubtring(string text, string searchFor)
        {
            int count = 0;
            int startpos = 0;

            startpos = text.IndexOf(searchFor, 0);

            while (startpos != -1)
            {
                ++count;
                Console.WriteLine(startpos);
                startpos = text.IndexOf(searchFor, 1 + startpos);
            }

            return count;
        }
    }
}
