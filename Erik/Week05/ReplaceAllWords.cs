using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erik.Week05
{
    internal class ReplaceAllWords
    {
        public static void Start()
        {
            ReplaceTheWord();
        }

        public static void ReplaceTheWord()
        {
            String randomText = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";
            String textChanged = randomText.Replace("wird", "war");
            Console.WriteLine(textChanged);
            String textChanged2 = randomText.Replace("wird", "ist");
            Console.WriteLine(textChanged2);

        }
    }
}
