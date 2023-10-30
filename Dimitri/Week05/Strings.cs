using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Ressources;
using static Dimitri.Week04.ConsoleInputPart2;
using static Dimitri.Week04.TwoDArray;
using static Dimitri.Week03.Array;
using System.Text.RegularExpressions;
using System.Runtime.ExceptionServices;
using System.Threading.Channels;
using System.ComponentModel.Design;

namespace Dimitri.Week05
{
    internal class Strings
    {
        public static Random random = new Random();
        public static void Main()
        {
            //string string1 = "Today is " + DateTime.Now.ToString("t") + ".";
            //Console.WriteLine(string1);

            //string sentence = "This sentence has five words.";
            //int startPosition = sentence.IndexOf(" ") + 1;
            //string word2 = sentence.Substring(startPosition,
            //                                  sentence.IndexOf(" ", startPosition) - startPosition);

            //Console.WriteLine("int 1. Summand length: " + sentence.IndexOf(" ", startPosition));
            //Console.WriteLine("second summand length " + startPosition);
            //Console.WriteLine("result length " + (sentence.IndexOf(" ", startPosition) - startPosition));
            //Console.WriteLine("Second word: " + word2);

            //DateTime dateAndTime = new DateTime(2011, 7, 6, 7, 32, 0);
            //double temperature = 68.3;
            //string result = String.Format("At {0:t} on {0:D}, the temperature was {1:F1} degrees Fahrenheit.",
            //                              dateAndTime, temperature);
            //Console.WriteLine(result);

            /*                                                      
            */

            //Console.WriteLine("BubblesortLength asc:");
            // String[] names1 = new String[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };
            // BubbleSortStringLength(names1, true);
            // PrintArray(names1, ",");

            //Console.WriteLine("BubblesortLength desc:");
            //String[] names2 = new String[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };
            //BubbleSortStringLength(names2, false);
            //PrintArray(names2, ",");

            //Console.WriteLine("BubblesortLex asc:");
            //String[] names3 = new String[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };
            //BubbleSortStringLex(names3, true);
            //PrintArray(names3, ",");

            //Console.WriteLine("BubblesortLex desc:");
            //String[] names4 = new String[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };
            //BubbleSortStringLex(names4, false);
            //PrintArray(names4, ",");

            //Console.WriteLine("bubblesortlex asc:");
            //String[] names5 = new String[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };
            //BubbleSortStringLexIndexByGyula(names5, true, 0);
            //PrintArray(names5, ",");

            //Console.WriteLine("BubblesortLex desc:");
            //String[] names6 = new String[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };
            //BubbleSortStringLexIndex(names6, false, 0);
            //PrintArray(names6, ",");

            //string word = Reverse("Wort");
            //Console.WriteLine(word);

            //string randomWord = Random("Nicht");
            //Console.WriteLine(randomWord);

            //ListLetterCount

            //string text = Ressources.StringRessources.getText();

            //PrintArrayToStringForI(ListLetterCount(text));

            //PrintLetterCount(ListLetterCount(text));

            //PrintTable();

            //string regex = "^[a-z]+[0-9]?[.]?[a-z0-9]*[@]{1}[a-z]+[.]{1}[a-z]{2}";
            //Regbert(regex);

            //Hesse
            //string text = Ressources.StringRessources.getHesse();
            //SearchForHesse(text, "Hesse");
            //Console.WriteLine();

            //string toMark = WordToUppercase(text, "Hesse");
            //Console.WriteLine(toMark);

            //Replace all
            //string textReplace = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";
            //Console.WriteLine(ReplaceAll(textReplace, "wird", "war"));
            //Console.WriteLine();
            //Console.WriteLine(ReplaceAll(textReplace, "wird", "ist"));
            //Console.WriteLine();
            ////Delete all;
            //Console.WriteLine(DeleteAll(textReplace, "[a-z]"));
            //Console.WriteLine();
            ////Delete all;
            //Console.WriteLine(DeleteAll(textReplace, "[A-Z]"));
            //Console.WriteLine();
            ////Delete all;
            //Console.WriteLine(DeleteAll(textReplace, "[\\s]"));
            //Console.WriteLine();
            ////Delete all;
            //Console.WriteLine(DeleteAll(textReplace, "[!]"));
            //Console.WriteLine();
            //Delete all
            //string numbersReplace = "749813247132984712039487123049871204398712039487";
            //Console.WriteLine(DeleteAll(numbersReplace, "[0-9]"));
            //Console.WriteLine();
            //Console.WriteLine(DeleteAll(numbersReplace, "[1-9]"));
            //Console.WriteLine();
            //Console.WriteLine(DeleteAll(numbersReplace, "[2-4]"));
            //Console.WriteLine();
            //Console.WriteLine(DeleteAll(numbersReplace, "[1-36-9]"));
            //Console.WriteLine();

            //FindLongestMatchingSubstring();

            //String text = Ressources.StringRessources.getHesse();
            //Console.WriteLine(text);
            //Console.WriteLine("Count \"Hesse\" in text: {0}", CountSubstringGyula(text, "Hesse"));


            //longest Substring by gyula

            String text1 = "Hello World!";
            String text2 = "Hello Patrick!";

            string longest = GetLongestSubstringGyula(text1, text2 );
            Console.WriteLine("{0}\n{1}\n{2}", text1, text2, longest);

            Console.WriteLine("=============================================");
            string longestWord = GetLongestWordGyula(text1, text2);
            Console.WriteLine("longest common word: " + longestWord);




        }

        public static string[] BubbleSortStringLength(string[] arr, bool asc)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if ((arr[j].Length > arr[j + 1].Length) == asc)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            return arr;

        }
        public static string[] BubbleSortStringLex(string[] arr, bool asc)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0 && asc == true)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                    else if (arr[j].CompareTo(arr[j + 1]) < 0 && asc == false)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }
            }

            return arr;
        }

        public static string CharAtIndex(string stringAtIndex, int indexLetter)
        {
            string result = "";

            try
            {
                result = char.ToString(stringAtIndex.ElementAt(indexLetter));
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                return result;
            }


            return result;
        }

        public static string CharAtIndexByGyula(string stringAtIndex, int indexLetter)
        {
            return char.ToString(stringAtIndex[indexLetter]);
        }

        public static string[] BubbleSortStringLexIndex(string[] arr, bool asc, int index)
        {
            // check if index of letter is out of range for string at all indexes
            string check = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (check.CompareTo(CharAtIndex(arr[i], index)) == 0)
                {
                    Console.WriteLine("Index out of range.");
                    Console.WriteLine();
                    return arr;
                }
            }

            //bubblesort with Letter at index

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {


                    if (CharAtIndex(arr[j], index).CompareTo(CharAtIndex(arr[j + 1], index)) > 0 && asc == true)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                    if (CharAtIndex(arr[j], index).CompareTo(CharAtIndex(arr[j + 1], index)) < 0 && asc == false)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }
            }

            return arr;

        }


        public static void BubbleSortStringLexIndexByGyula(string[] arr, bool asc, int index)
        {
            //bubblesort with Letter at index

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    Console.WriteLine(arr[j][index]);
                    if (arr[j + 1].Length <= index || (arr[j].Length > index && arr[j][index] > arr[j + 1][index]))
                    {
                        string temp = arr[j];

                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }


        }


        public static string ReverseOwn(string str)
        {
            char[] charArr = str.ToCharArray();

            string result = "";

            for (int i = charArr.Length - 1; i >= 0; i--)
            {
                result += charArr[i];
            }

            return result;
        }

        public static string Reverse(string str)
        {
            char[] charArr = str.ToCharArray();
            int j = 0;

            for (int i = charArr.Length - 1; i >= charArr.Length / 2; i--)
            {
                if (j == i)
                {
                    j++;
                }
                else
                {
                    char tmp = charArr[i];
                    charArr[i] = charArr[j];
                    charArr[j] = tmp;
                    j++;
                }
            }

            return new string(charArr);
        }

        public static string Random(string str)
        {
            Random random = new Random();

            char[] charArr = str.ToCharArray();

            while (new string(charArr).CompareTo(str) == 0)
            {

                for (int i = charArr.Length - 1; i > charArr.Length; i--)
                {

                    int j = random.Next(charArr.Length);
                    char tmp = charArr[i];
                    charArr[i] = charArr[j];
                    charArr[j] = tmp;
                }
            }

            return new string(charArr);

        }

        public static string RandomByGyula(string str)
        {
            char[] charArr = str.ToCharArray();


            for (int i = 0; i < 3 * charArr.Length; i++)
            {
                int t1 = random.Next(charArr.Length);
                int t2 = random.Next(charArr.Length);
                char tmp = charArr[t1];
                charArr[t1] = charArr[t2];
                charArr[t2] = tmp;
            }


            return new string(charArr);

        }

        public static void PrintLetterCount(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    Console.WriteLine((char)i + " " + arr[i]);
                }
            }
        }


        public static int[] ListLetterCount(string text)
        {

            int[] arr = new int[char.MaxValue];

            int count = 0;
            while (count < text.Length)
            {
                char c = text[count];
                arr[c] += 1;
                count++;
            }



            return arr;
        }


        public static void PrintTable()
        {
            //strings in table
            String[] firstName = { "Alfonso", "Beatrix-Eleonor", "Cecil", "Daniel", "Elmar" };
            String[] lastName = { "Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma" };
            int[] age = { 40, 78, 5, 18, 81 };
            String[] place = { "Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten" };
            float[] distanceFromCapital = { 0f, 654.4f, 12.457634366f, 120.0f, 119.9999f };
            //calculate max width

            //table
            //create arr for header
            string[] header = new string[] { "first name", "last name", "age", "place", "distance from capital" };

            //Console.Write(new string('-', header.Length));
            //Console.WriteLine();
            //Console.Write(header);
            //Console.WriteLine();
            //Console.Write(new string('-', header.Length));
            //Console.WriteLine();

            //create table
            string[][] table = new string[6][];

            //fill 2d array with strin arr
            for (int i = 0; i < table.Length; i++)
            {
                string[] row = new string[5];
                table[i] = row;
            }
            //fill header row

            for (int i = 0; i < table[0].Length; i++)
            {
                table[0][i] = header[i];
            }
            //fill table
            for (int i = 0; i < table[0].Length; i++)
            {

                table[i + 1][0] = firstName[i];
                table[i + 1][1] = lastName[i];
                table[i + 1][2] = age[i].ToString();
                table[i + 1][3] = place[i];
                table[i + 1][4] = distanceFromCapital[i].ToString();
            }

            PrintArray2dTable(table);
        }

        public static void PrintArray2dTable(string[][] array)
        {

            for (int row = 0; row < array.Length; row++)
            {
                Console.Write("|");
                for (int col = 0; col < array[row].Length; col++)
                {
                    Console.Write(" {0} |", array[row][col]);
                }
                Console.WriteLine();

            }
        }

        public static void Regbert(string regex)
        {

            Console.WriteLine(Regex.IsMatch("alfons@drlue.at", regex));

            Console.WriteLine(Regex.IsMatch("rambina.alfons@drlue.at", regex));

            Console.WriteLine(Regex.IsMatch("rambina1.1alfons@drlue.at", regex));

            Console.WriteLine(Regex.IsMatch("1rambina1.alfons@drlue.at", regex));

            Console.WriteLine(Regex.IsMatch("@drlue.at", regex));

            Console.WriteLine(Regex.IsMatch("drlue.at", regex));

            Console.WriteLine(Regex.IsMatch("asdf@drlue", regex));

            Console.WriteLine(Regex.IsMatch("asdf@microsoft.c", regex));
        }

        public static void SearchForHesseEasy(string text, string word)
        {

            Console.WriteLine(Regex.Count(text, word));

        }

        public static void SearchForHesse(string text, string word)
        {

            MatchCollection matches = Regex.Matches(text, word);

            Console.WriteLine("{0} matches of the word {1} found.", matches.Count, word);

            Console.WriteLine("Indices of the matches of the word {0} are: ", word);
            bool first = true;
            foreach (Match match in matches)
            {
                if (!first)
                {
                    Console.Write(", ");
                }
                Console.Write("{0}", match.Index);
                first = false;
            }
            Console.WriteLine();

        }

        public static string WordToUppercase(string text, string word)
        {
            return Regex.Replace(text, word, word.ToUpper());
        }

        public static string ReplaceAll(string text, string replace, string replaceWith)
        {
            return Regex.Replace(text, replace, replaceWith);
        }

        public static string DeleteAll(string text, string replace)
        {
            return Regex.Replace(text, replace, "");
        }

        public static void FindLongestMatchingSubstring()
        {
            Console.WriteLine("Bitte gib Wort 1 ein:");
            Console.Write(">>>");
            string string0 = InputString();
            Console.WriteLine("Bitte gib Wort 2 ein:");
            Console.Write(">>>");
            string string1 = InputString();
            Console.WriteLine("längster gemeinsamer Substring:");
            Console.WriteLine(LongestMatchingSubstring(string0, string1));
        }

        public static string InputString()
        {
            string input = Console.ReadLine();
            return input;
        }

        public static string LongestMatchingSubstring(string userString0, string userString1)
        {
            //string subString = "";
            //int wordcount0 = Regex.Count(userString0, "\\w");

            //int wordcount1 = Regex.Count(userString1, "\\w");

            //string[] text0 = new string[wordcount0];
            //// write userString0 to array

            //string[] text1 = new string[wordcount1];
            //// write usertstring1 to array

            //BubbleSortStringLength(text0, false);

            //BubbleSortStringLength(text1, false);

            //for (int i = 0; i < text0.Length; i++)
            //{
            //    for (int j = 0; j < text1.Length; j++)
            //    {
            //        if (text0[i] == text1[j] && text0[i].Length > text1[j].Length)
            //        { 
            //            return text0[i]; 
            //        }
            //        else if (text0[i] == text1[j] && text0[i].Length < text1[j].Length) 
            //        { 
            //            return text0[i]; 
            //        }
            //    }
            //}


            string word = string.Empty;

            //int text0Length = 0;

            int text0Length = Regex.Count(userString0, "[\\s]");

            int text1Length = Regex.Count(userString1, "[\\s]");

            //int text1Length = 0;

            //for (int i = 0; i < userString1.Length; i++)
            //{
            //    if (!char.IsLetter(userString1[i]))
            //    {
            //        text1Length++;
            //    }

            //}


            string[] text0 = new string[text0Length + 1];

            int count = 0;

            for (int i = 0; i < text0.Length; i++)
            {
                for (int j = count; j < userString0.Length; j++)
                {
                    if (char.IsLetter(userString0[j]))
                    {
                        word += userString0[j];
                        count++;

                    }
                    else
                    {
                        count++;
                        text0[i] = word;
                        word = string.Empty;
                        break;
                    }
                }
            }

            string[] text1 = new string[text1Length + 1];

            count = 0;

            for (int i = 0; i < text1.Length; i++)
            {
                for (int j = count; j < userString1.Length; j++)
                {

                    if (char.IsLetter(userString1[j]))
                    {
                        word += userString1[j];
                        count++;

                    }
                    else
                    {
                        count++;
                        text1[i] = word;
                        word = string.Empty;
                        break;
                    }

                }
            }

            // find index of array that is null
            //int endOfText0 = 0;
            //for (int i = 0; i < text0.Length; i++)
            //{
            //    if (text0[i] == null)
            //    {
            //        endOfText0 = i;
            //        break;
            //    }
            //}

            //int endOfText1 = 0;
            //for (int i = 0; i < text1.Length; i++)
            //{
            //    if (text1[i] == null)
            //    {
            //        endOfText1 = i;
            //        break;
            //    }
            //}

            ////make a shorter array

            //string[] cleanedText0 = CopyArrayUntilIndex(text0, endOfText0);
            //string[] cleanedText1 = CopyArrayUntilIndex(text1, endOfText1);

            //order array by length
            BubbleSortStringLength(text0, false);

            BubbleSortStringLength(text1, false);

            for (int i = 0; i < text0.Length; i++)
            {
                for (int j = 0; j < text0.Length; j++)
                {
                    if (text0[i] == text1[j])
                    {
                        return text0[i];
                    }

                    return "No matching substrings";
                }
            }

            return "Wow";

        }

        public static string[] CopyArrayUntilIndex(string[] text, int index)
        {
            string[] result = new string[index];

            for (int i = 0; i < index; i++)
            {
                result[i] = text[i];
            }

            return result;
        }

        public static int CountSubstringGyula(string text, string searchFor)
        {
            int count = 0;
            int startPos = text.IndexOf(searchFor, 0);

            while (startPos > -1)
            {
                ++count;
                startPos = text.IndexOf(searchFor, 1 + startPos);
            }

            return count;
        }

        public static string GetLongestWordGyula(string text1, string text2)
        {
            string[] words1 = text1.Split(" ");
            string[] words2 = text2.Split(" ");


            string result = "";

            for (int i = 0; i < words1.Length; i++)
            {
                for (int j = 0; j < words2.Length; j++)
                {
                    if (words1[i] == words2[j] && words1[i].Length > result.Length)
                    {
                        result = words1[i];
                    }
                }
            }
            return result;
        }

        public static string GetLongestSubstringGyula(string longText, string shortText)
        {

            if(longText.Length < shortText.Length)
            {
                return GetLongestSubstringGyula(shortText, longText);
            }

            string result = "";

            int targetLength = shortText.Length;
            while (targetLength > 0)
            {
                for (int startPos = 0; startPos <= shortText.Length - targetLength; ++startPos)
                {
                    string textForSearch = shortText.Substring(startPos, targetLength);
                    if (longText.Contains(textForSearch))
                    {
                        result = textForSearch;
                    }
                }

                --targetLength;
            }

            return result;
        }
    }
}

