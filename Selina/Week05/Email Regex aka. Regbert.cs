using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selina.Week05
{
    internal class Email_Regex_aka
    {
        public static void Start()
        {
            ReadText("Gib deine E-Mail ein:");
        }
        public static string ReadText(string prompt)
        {
            Console.Write(prompt);
            while (true)
            {
                try
                {
                    string text = Convert.ToString(Console.ReadLine());
                    return text;
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);

                }
            }
        }

    }
}
