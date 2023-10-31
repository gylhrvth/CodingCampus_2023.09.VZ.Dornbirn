using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hassan.Week05
{
    public class ReplaceAll
    {
        public static void Start()
        {
            String text = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";

            String replacedtext = text.Replace("wird", "war und ist");
            Console.WriteLine(replacedtext);

            Console.WriteLine("----------");
            String output = Regex.Replace(text,"[a-z]", "");
            Console.WriteLine("Ohne Kleinbuchstaben: " + output);

            Console.WriteLine("-----------");
            String output2 = Regex.Replace(text, "[A-Z]", "");
            Console.WriteLine("Ohne Großbuchtsaben: " + output2);

            Console.WriteLine("------------");
            String outout3 = Regex.Replace(text, " ", "");
            Console.WriteLine("Ohne Leerzeichen: " + outout3);

            Console.WriteLine("-------------");
            String output4 = Regex.Replace(text, "!", "");
            Console.WriteLine("Ohne Rufezeichen: " + output4);

            Console.WriteLine("------------------------------------------------------------");

            String text2 = "749813247132984712039487123049871204398712039487";

            String num = Regex.Replace(text, "[0-9]", "");
            Console.WriteLine("Ohne 0 - 9 : " + num);

            Console.WriteLine("--------------");
            String num2 = Regex.Replace(text, "[1-9]", "");
            Console.WriteLine("Ohne 1 - 9: " + num2);

            Console.WriteLine("---------------");
            String num3 = Regex.Replace(text, "[2-4]", "");
            Console.WriteLine("Ohne 2 - 4: " + num3);

            Console.WriteLine("----------------");
            String num4 = Regex.Replace(text, "[1-36-9]", "");
            Console.WriteLine("Ohne 1 -3 und 6 - 9: " + num4);
        }

    }
}
