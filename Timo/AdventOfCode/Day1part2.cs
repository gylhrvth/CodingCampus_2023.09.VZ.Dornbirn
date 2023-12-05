using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.AdventOfCode
{
    public class Day1part2
    {
        public static void Start()
        {
            string path = "C:\\Users\\BAU27722\\OneDrive - Julius Blum GmbH\\AdventOfCode\\Day1.txt";

            string text = ReadText(path);
            string[] strings = text.Split('\n');
            Console.WriteLine(SumNumbers(strings));
            Console.WriteLine(SumNumbersWithWords(strings));
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
            int sum = 0;
            for (int i = 0; i < strings.Length; i++)
            {
                char[] chars = strings[i].ToCharArray();
                int numbersfound = 0;
                char first = '0';
                char last = '0';
                for (int j = 0; j < chars.Length; j++)
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
                sum += Nr1;
            }
            return sum;
        }

        public static int SumNumbersWithWords(string[] strings)
        {
            int sum = 0;
            foreach (string line in strings)
            {
                string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in words)
                {
                    sum += ConvertWordToNumber(word);
                }
            }
            return sum;
        }

        public static int ConvertWordToNumber(string word)
        {
            switch (word)
            {
                case "one":
                    return 1;
                case "two":
                    return 2;
                case "three":
                    return 3;
                case "four":
                    return 4;
                case "five":
                    return 5;
                case "six":
                    return 6;
                case "seven":
                    return 7;
                case "eight":
                    return 8;
                case "nine":
                    return 9;
                default:
                    return 0; // Handle cases where the word is not a spelled-out number
            }
        }
    }


}
