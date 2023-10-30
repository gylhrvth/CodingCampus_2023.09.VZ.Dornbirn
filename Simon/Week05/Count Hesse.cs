using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using Ressources;

namespace Simon.Week05
{
    internal class Count_Hesse
    {
        public static void Start()
        {
            String text = Ressources.StringRessources.getHesse();
            Console.WriteLine(text);
            Console.WriteLine("Count \"Hesse\" in text: {0}", CountSubstring(text, "Hesse"));
        }

        public static int CountSubstring(string text, string searchFor)
        {
            int count = 0;
            int startPos = text.IndexOf(searchFor, 0);

            text.IndexOf(searchFor, 295);

            while (startPos > -1)
            {
                ++count;
                startPos = text.IndexOf(searchFor, 1 + startPos);
            }

            return count;
        }


    }
}
