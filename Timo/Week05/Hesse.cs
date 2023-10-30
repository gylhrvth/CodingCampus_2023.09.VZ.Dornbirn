using Ressources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week05
{
    internal class Hesse
    {
        public static void Start()
        {
            string text = StringRessources.getHesse();
            Console.WriteLine("Count \"Hesse\" in text: {0}", CountSubstring(text, "Hesse"));
        }

        public static int CountSubstring(string text, string searchFor)
        {
            int count = 0;
            int startPos = text.IndexOf(searchFor, 0);

            while (startPos > -1)
            {
                ++count;
                startPos = text.IndexOf(searchFor, startPos+1);
            }

            return count;
        }
    }
}
