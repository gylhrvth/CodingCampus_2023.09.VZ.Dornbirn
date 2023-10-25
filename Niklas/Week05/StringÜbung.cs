﻿using Niklas.Week04;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Threading.Channels;
using Ressources;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Niklas.Week05
{
    internal class StringÜbung
    {
        public static void Start()
        {
            String[] names = new String[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };

            //BubblesortAsc(names);
            //PrintArray(names);
            //BubblesortDesc(names);
            //PrintArray(names);
            //BubblesortAlphabetAsc(names);
            //PrintArray(names);
            //BubblesortAlphabetDesc(names);
            //PrintArray(names);
            //BubblesortBoolean(names, false);
            //PrintArray(names);
            //BubblesortIndex(names);
            //PrintArray(names);

            //Console.WriteLine("Enter something you want to be reversed: ");
            //String input = Console.ReadLine();
            //Reverse(input);

            //Console.WriteLine("Randomized: ");
            //randomizer(input);

            //string r = StringRessources.getText();
            //Console.WriteLine("How many letters of each: ");
            //lettercount(r);

            //tabellen();

            RegexEmail();

            //string gethesse = Ressources.StringRessources.getHesse();
            Hesse();

            String text = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";

            Replace(text);
            Replace2(text);
            Replace3();

            LongestSubstring();
        }
        public static void BubblesortAsc(String[] names)
        {
            int i = 0;

            for (i = 0; i < names.Length - 1; i++)
            {
                for (int j = 0; j < names.Length - 1 - i; j++)
                {
                    if (names[j].Length > names[j + 1].Length)
                    {
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Ascend:");
        }
        public static void BubblesortDesc(String[] names)
        {
            int i = 0;

            for (i = 0; i < names.Length - 1; i++)
            {
                for (int j = 0; j < names.Length - 1 - i; j++)
                {
                    if (names[j].Length < names[j + 1].Length)
                    {
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Descend:");
        }
        public static void BubblesortAlphabetAsc(String[] names)
        {
            int i = 0;

            for (i = 0; i < names.Length - 1; i++)
            {
                for (int j = 0; j < names.Length - 1 - i; j++)
                {
                    if (names[j].CompareTo(names[j + 1]) > 0)
                    {
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Ascend by Alphabet:");
        }
        public static void BubblesortAlphabetDesc(String[] names)
        {
            int i = 0;

            for (i = 0; i < names.Length - 1; i++)
            {
                for (int j = 0; j < names.Length - 1 - i; j++)
                {
                    if (names[j].CompareTo(names[j + 1]) < 0)
                    {
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Descend by Alphabet:");
        }
        public static void BubblesortBoolean(String[] names, bool cases)
        {
            int i = 0;

            if (cases == true)
            {
                for (i = 0; i < names.Length - 1; i++)
                {
                    for (int j = 0; j < names.Length - 1 - i; j++)
                    {
                        if (names[j].Length > names[j + 1].Length)
                        {
                            string temp = names[j];
                            names[j] = names[j + 1];
                            names[j + 1] = temp;
                        }
                    }
                }
            }
            else if (!cases)
            {
                for (i = 0; i < names.Length - 1; i++)
                {
                    for (int j = 0; j < names.Length - 1 - i; j++)
                    {
                        if (names[j].Length < names[j + 1].Length)
                        {
                            string temp = names[j];
                            names[j] = names[j + 1];
                            names[j + 1] = temp;
                        }
                    }
                }
            }
            Console.WriteLine("Ascend or Descend:");
        }
        public static void BubblesortIndex(String[] names)
        {
            for (int i = 0; i < names.Length - 1; i++)
            {
                for (int j = 0; j < names.Length - 1 - i; j++)
                {
                    if (names[j][2].CompareTo(names[j + 1][2]) > 0)
                    {
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Sort by 3rd character:");
        }

        public static void Reverse(String input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string Output = new string(charArray);
            Console.WriteLine(Output);
        }

        public static void randomizer(String input)
        {
            char[] charArray = input.ToCharArray();
            Random random = new Random();

            for (int i = 0; i < charArray.Length; i++)
            {
                int randomi = random.Next(charArray.Length);
                char temp = charArray[i];
                charArray[i] = charArray[randomi];
                charArray[randomi] = temp;
            }

            string shuffleword = new string(charArray);

            Console.WriteLine(shuffleword);
        }

        public static void lettercount(String text)
        {
            Console.WriteLine(text);
            int[] count = countLetters(text);

            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > 0)
                {
                    char c = (char)i;
                    Console.WriteLine(c + " " + count[i]);
                }
            }
        }

        public static void tabellen()
        {
            string name = "Names: ";
            string lname = "Last names: ";
            string agea = "age: ";
            string liv = "living place: ";
            string distance = "distance from capital: ";

            string space = new string(Convert.ToChar(" "), 0);
            string underscore = new string(Convert.ToChar("_"), 130);

            String[] firstName = { "Alfonso", "Beatrix-Eleonor", "Cecil", "Daniel", "Elmar" };
            String[] lastName = { "Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma" };
            int[] age = { 40, 78, 5, 18, 81 };
            String[] place = { "Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten" };
            float[] distanceFromCapital = { 0f, 654.4f, 12.457634366f, 120.0f, 119.9999f };

            Console.WriteLine($"{name,0} {lname,30} {agea,20} {liv,31} {distance,31}");
            Console.WriteLine(underscore);
            for (int i = 0; i < age.Length; i++)
            {
                Console.Write("|{0}", string.Join(space, $"{firstName[i],-24}") + $"{"|"}" + string.Join(space, $"{lastName[i],-12}") + space + $"{"|",16}" + string.Join(space, $"{age[i],-2}") + space + $"{"|",21}" + string.Join(space, $"{place[i],-22}") + space + "|" + string.Join(space, $"{distanceFromCapital[i],-8}") + "\n");
            }
            Console.WriteLine(underscore);
        }

        public static void RegexEmail()
        {
            String regex = "[richtiger regex hier]";

            Console.WriteLine(Regex.IsMatch("alfons@drlue.at", regex));
            Console.WriteLine(Regex.IsMatch("rambina.alfons@drlue.at", regex));
            Console.WriteLine(Regex.IsMatch("rambina1.1alfons@drlue.at", regex));
            Console.WriteLine(Regex.IsMatch("1rambina1.alfons@drlue.at", regex = Convert.ToString(false)));
            Console.WriteLine(Regex.IsMatch("@drlue.at", regex = Convert.ToString(false)));
            Console.WriteLine(Regex.IsMatch("drlue.at", regex = Convert.ToString(false)));
            Console.WriteLine(Regex.IsMatch("asdf@drlue", regex = Convert.ToString(false)));
            Console.WriteLine(Regex.IsMatch("asdf@microsoft.c", regex = Convert.ToString(false)));
            Console.WriteLine();
            //?
        }

        public static void Hesse()
        {

        }

        public static void Replace(String text)
        {
            Console.WriteLine("Old text: " + text);
            Console.WriteLine("New text: " + text.Replace("wird", "war"));
            Console.WriteLine("New text: " + text.Replace("wird", "ist"));
            Console.WriteLine();
        }

        public static void Replace2(String text)
        {
            Console.WriteLine("Old text: " + text);
            Console.WriteLine("__________________");

            Regex regex = new Regex("[^A-Z]");
            Console.Write("Without small letters>>> ");
            Console.WriteLine(regex.Replace(text, ""));
            Console.WriteLine("__________________");

            Regex regex2 = new Regex("[^a-z]");
            Console.Write("Without big letters>>> ");
            Console.WriteLine(regex2.Replace(text, ""));
            Console.WriteLine("__________________");

            Console.Write("Without space>>> ");
            Console.WriteLine(text.Replace(" ", ""));
            Console.WriteLine("__________________");

            Console.Write("Without exlamation mark>>> ");
            Console.WriteLine(text.Replace("!", ""));
            Console.WriteLine("__________________");
            Console.WriteLine();
        }

        public static void Replace3()
        {
            String text = "749813247132984712039487123049871204398712039487";
            Console.WriteLine("Before: " + text);
            Console.Write("Remove 0 to 9: ");
            Console.WriteLine(text.Replace(text, ""));
            Console.WriteLine();

            Regex regex2 = new Regex("[^0]");
            Console.Write("Remove 1 to 9: ");
            Console.WriteLine(regex2.Replace(text, ""));
            Console.WriteLine();

            Regex regex3 = new Regex("[^2-4]");
            Console.Write("Remove 2 to 4: ");
            Console.WriteLine(regex3.Replace(text, ""));
            Console.WriteLine();

            Regex regex4 = new Regex(@"[^4-5][^0-1]");
            Console.Write("Remove 1 to 3 and 6 to 9: ");
            Console.WriteLine(regex4.Replace(text, ""));
            Console.WriteLine();
        }

        public static void LongestSubstring()
        {
            Console.Write("Enter a sentence: ");
            String input = Console.ReadLine();
            Regex regex = new Regex($"@[^{input}]");
            Console.Write("Enter another sentence: ");
            String input2 = Console.ReadLine();
            //Regex regex = new Regex;

            char[] charArray = input.ToCharArray();
            char[] charArray2 = input2.ToCharArray();

            if (charArray == charArray2)
            {
                Console.WriteLine("The longest substring is: " + charArray);
            }

            Console.WriteLine(Regex.IsMatch(input, input2));

            //if (input == input2)
            //{
            //    Console.WriteLine("längster gemeinsamer substring: " + regex);
            //}
        }

        public static void PrintArray(String[] names)
        {
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        public static int[] countLetters(String text)
        {
            int[] count = new int[char.MaxValue];
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                ++count[c];
            }
            return count;
        }
    }
}