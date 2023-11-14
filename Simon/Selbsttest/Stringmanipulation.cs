using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Simon.Selbsttest
{
    internal class Stringmanipulation
    {
        public static void Start()
        {
            string Word1 = "apfel";
            string Word2 = "regalager";
            string Word3 = "Hannah";
            string Word4 = "reittier";

            Console.WriteLine(Word2 + " = " + IsWordPalindrom(Word2));

            string text = Ressources.StringRessources.getHesse();
            string text2 = Ressources.StringRessources.getText();

            string text3 = text + text2;

            Console.WriteLine(text3);

            Console.WriteLine("Longestword is: " + GetLongestWordofText(text3));
            Console.WriteLine("Shortestword is: " + GetShortestWordofText(text3));
            //Console.WriteLine("Shortestword is: " + GetShortestWordofText2(text3));

        }




        public static bool IsWordPalindrom(string word)
        {
            string newword = word.ToUpper();
            char[] chars = newword.ToCharArray();
            bool Palindrom = true;
            for (int i = 0; i < chars.Length / 2; i++)
            {
                if (chars[i] != chars[chars.Length - i - 1])
                {
                    Palindrom = false;
                    break;
                }
            }
            return Palindrom;
        }

        public static string GetLongestWordofText(string text)
        {
            string[] arr = text.Split(' ', '\n', '.', ')', '(', ',', '"', '+', '\'', '\t');


            string longestword = arr[0];
            foreach (string word in arr)
            {
                if (longestword.Length < word.Length)
                {
                    longestword = word;
                }
            }

            return longestword;
        }


        public static string GetShortestWordofText(string text)
        {
            //char[] chars = { ' ', '\n', '.', ')', '(', ',', '"', '+', '\'', '\r', '$', '-'};
            //string[] arr = text.Split(chars, StringSplitOptions.RemoveEmptyEntries);
            string[] arr = Regex.Split(text, @"\W+");
            string shortestword = arr[0];

            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i].Length == 2)
                {
                    Console.WriteLine($"Word: '{arr[i]}' - Length: {arr[i].Length}");

                }
                if (!int.TryParse(arr[i], out _))
                {
                    if (shortestword.Length > arr[i].Length /*&& arr[i].Length > 0*/ && arr[i].Length >=2)
                    {
                        shortestword = (arr[i]);
                    }
                }          
            }

            return shortestword;
        }



    }
}
