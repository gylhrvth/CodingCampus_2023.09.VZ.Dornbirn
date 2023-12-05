using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timo.Selbsttest_Strukto;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Timo.AdventOfCode
{
    public class Day01
    {
        public static void Start()
        {
            string path = "C:\\Users\\BAU27722\\Downloads\\input.txt";

            string text = ReadText(path);
            string[] strings = text.Split('\n');
            Console.WriteLine(SumNumbers(strings));
            
        }
        public static string ReadText(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line = sr.ReadToEnd();
                return line;
            }
        }
        public static int SumNumbers(string[] strings)
        {
            int sum =0;
            for (int i = 0; i < strings.Length; i++)
            {
                char[] chars = strings[i].ToCharArray();
                int numbersfound = 0;
                char first = '0';
                char last = '0';
                for (int j=0; j<chars.Length; j++)
                {
                    if (chars[j] >= '0' && chars[j] <= '9')
                    {
                        if (numbersfound == 0)
                        {
                            first = chars[j];
                            last = chars[j];
                        }
                        else
                        {
                            last = chars[j];
                        }
                        numbersfound++;
                    }
                    
                }
                string number = first.ToString() + last.ToString();
                int Nr1 = int.Parse(number);
                Console.WriteLine(Nr1);
               sum += Nr1;
            }
            return sum;
        }

    }
}
