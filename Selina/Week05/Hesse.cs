using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ressources;

namespace Selina.Week05
{
    internal class Hesse
    {
        public static void Start()
        {
            String text = StringRessources.getHesse();
            Console.WriteLine(text);
            Console.WriteLine("Count \"Hesse\" in text : {0}", CountSubstring(text, "Hesse"));
        }

        public static int CountSubstring(String text, string searchFor)
        {
            int count = 0;
            int startPos = text.IndexOf(searchFor, 0);

            while (startPos > -1)
            {
                count++;
                startPos = text.IndexOf(searchFor, 1+ startPos);
            }
            return count;
        }

    }
}
