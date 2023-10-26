using Mehmet.Week04;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Mehmet.Week04.Input;
using Ressources;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

namespace Mehmet.Week05
{
    internal class StringExamples
    {
        public static Random rand = new Random();
        public static String[] namesarr = new String[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };


        public static void Start()
        {
            //Console.WriteLine("BubbleSortNamesAscending");
            //Console.WriteLine("------------------------------------");
            //BubbleSortNamesAscending(namesarr);
            //Console.WriteLine("====================================");

            //Console.WriteLine("BubbleSortNamesDescending");
            //Console.WriteLine("------------------------------------");
            //BubbleSortNamesDescending(namesarr);
            //Console.WriteLine("====================================");

            //Console.WriteLine("BubbleSortNamesAscendingLexikographisch");
            //Console.WriteLine("------------------------------------");
            //BubbleSortNamesAscendingLexikographisch(namesarr);
            //Console.WriteLine("====================================");

            //Console.WriteLine("BubbleSortNamesDescendingLexikographisch");
            //Console.WriteLine("------------------------------------");
            //BubbleSortNamesDescendingLexikographisch(namesarr);
            //Console.WriteLine("====================================");

            //Console.WriteLine("BubbleSortNamesLexikographisch");
            //Console.WriteLine("------------------------------------");
            //BubbleSortNamesLexikographisch(namesarr, true);
            //Console.WriteLine("====================================");

            //Console.WriteLine("BubbleSortNamesIndex");
            //Console.WriteLine("------------------------------------\n");
            //BubbleSortNamesIndex(namesarr,2,true);
            //Console.WriteLine("====================================");

            //Console.WriteLine("ExampleReverse");
            //Console.WriteLine("-------------------------------------");
            //string input = ReadSymbol("Tippe was ein:  ");
            //Console.WriteLine(ExampleReverse(input));

            //Console.WriteLine("ExampleRandomize");
            //Console.WriteLine("-------------------------------------");
            //string input = ReadSymbol("Tippe was ein:  ");
            //Console.WriteLine(ExampleRandomize(input));

            //Console.WriteLine("CountLetter");
            //Console.WriteLine("-------------------------------------");
            //StartCountLetter();

            Console.WriteLine("DatenTabellarischDarstellen");
            Console.WriteLine("-------------------------------------");
            DatenTabellarischDarstellen();
        }


        public static void BubbleSortNamesAscending(string[] namesarr)
        {
            for (int i = 0; i < namesarr.Length - 1; i++)
            {
                for (int j = 0; j < namesarr.Length - 1; j++)
                {
                    string name1 = namesarr[j];
                    string name2 = namesarr[j + 1];

                    if (name1.Length > name2.Length)
                    {
                        namesarr[j] = name2;
                        namesarr[j + 1] = name1;
                    }
                }
            }
            Console.WriteLine("{0}", string.Join(" < ", namesarr));
        }
        public static void BubbleSortNamesDescending(string[] namesarr)
        {
            for (int i = 0; i < namesarr.Length - 1; i++)
            {
                for (int j = 0; j < namesarr.Length - 1; j++)
                {
                    string name1 = namesarr[j];
                    string name2 = namesarr[j + 1];

                    if (name1.Length < name2.Length)
                    {
                        namesarr[j] = name2;
                        namesarr[j + 1] = name1;
                    }
                }
            }
            Console.WriteLine("{0}", string.Join(" > ", namesarr));
        }
        public static void BubbleSortNamesAscendingLexikographisch(string[] namesarr)
        {
            for (int i = 0; i < namesarr.Length - 1; i++)
            {
                for (int j = 0; j < namesarr.Length - 1; j++)
                {
                    string name1 = namesarr[j];
                    string name2 = namesarr[j + 1];
                    if (string.Compare(name1, name2) > 0)
                    {
                        namesarr[j] = name2;
                        namesarr[j + 1] = name1;
                    }
                }
            }
            Console.WriteLine("{0}", string.Join(" , ", namesarr));
        }
        public static void BubbleSortNamesDescendingLexikographisch(string[] namesarr)
        {
            for (int i = 0; i < namesarr.Length - 1; i++)
            {
                for (int j = 0; j < namesarr.Length - 1; j++)
                {
                    string name1 = namesarr[j];
                    string name2 = namesarr[j + 1];
                    if (string.Compare(name1, name2) < 0)
                    {
                        namesarr[j] = name2;
                        namesarr[j + 1] = name1;
                    }
                }
            }
            Console.WriteLine("{0}", string.Join(" , ", namesarr));
        }
        public static void BubbleSortNamesLexikographisch(string[] namesarr, bool a)
        {
            int mynumber = ReadNumber("Type 1 for Ascending Lexikographisch | Type 2 for Descending Lexikographisch:  ");
            a = true;
            while (a)
            {
                if (mynumber == 1)
                {
                    BubbleSortNamesAscendingLexikographisch(namesarr);
                    a = false;
                }
                else if (mynumber == 2)
                {
                    BubbleSortNamesDescendingLexikographisch(namesarr);
                    a = false;
                }
            }
        }
        public static void BubbleSortNamesIndex(string[] namesarr, int index, bool a)
        {
            Console.WriteLine($"Sortieren nach Buchstabe stelle:  {index + 1}");
            Console.WriteLine();
            while (a)
            {
                int mynumber = ReadNumber("Type 1 for Ascending Lexikographisch | Type 2 for Descending Lexikographisch:  ");
                for (int i = 0; i < namesarr.Length - 1; i++)
                {
                    for (int j = 0; j < namesarr.Length - 1; j++)
                    {
                        char name1 = namesarr[j][index];
                        char name2 = namesarr[j + 1][index];
                        int comparsion = string.Compare(name1.ToString(), name2.ToString());
                        if (mynumber == 1)
                        {
                            if (comparsion > 0)
                            {
                                string temp = namesarr[j];
                                namesarr[j] = namesarr[j + 1];
                                namesarr[j + 1] = temp;
                                a = false;
                            }
                        }
                        else if (mynumber == 2)
                        {
                            if (comparsion < 0)
                            {
                                string temp = namesarr[j];
                                namesarr[j] = namesarr[j + 1];
                                namesarr[j + 1] = temp;
                                a = false;
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("{0}", string.Join(", ", namesarr));
        }
        public static string ExampleReverse(string input)
        {

            char[] arr = input.ToCharArray();
            for (int i = 0; i < input.Length / 2; i++)
            {
                char temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;

                //    Console.WriteLine(new string(arr));

            }
            return new string(arr);

        }
        public static string ExampleRandomize(string input)
        {
            char[] arr = input.ToCharArray();
            for (int i = 0; i < arr.Length * 5; i++)
            {
                int posA = rand.Next(arr.Length);
                int posB = rand.Next(arr.Length);
                char temp = arr[posA];
                arr[posA] = arr[posB];
                arr[posB] = temp;
            }
            return new string(arr);
        }
        public static void StartCountLetter()
        {
            string text = StringRessources.getText();
            Console.WriteLine(text);
            //char[] textarr = text.ToCharArray();
            int[] cnt = CountLetter(text);
            PrintCountResult(cnt);
        }
        public static void PrintCountResult(int[] count)
        {
            for (char c = (char)0; c < char.MaxValue; ++c)
            {
                if (c < count.Length && count[c] > 0)
                    Console.WriteLine(c + " " + count[c]);
            }
        }
        public static int[] CountLetter(string text)
        {
            int[] count = new int[char.MaxValue];
            char[] textarr = text.ToCharArray();

            for (int i = 0; i < textarr.Length; i++)
            {
                //Console.WriteLine(text[i] + " " + (int)text[i]);
                count[textarr[i]]++;
            }
            return count;
        }
        public static void DatenTabellarischDarstellen()
        {
            string[] firstname = { "Alfonso", "Beatrix-Eleonor", "Cecil", "Daniel", "Elmar" };
            string[] lastname = { "Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma" };
            int[] age = { 40, 78, 5, 18, 81 };
            string[] place = { "Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten" };
            float[] distanceFromCapital = { 0f, 654.4f, 12.457634366f, 120.0f, 119.9999f };

            int col = 5;

            //string[][col] columnds = Add2DArray();
            


            
            AddCol(firstname);
            AddCol(lastname);
        }


        public static void AddCol(string[] aaaa)
        {
            Console.WriteLine("Firstname" + "\n" + string.Join("\n", aaaa));
        }



    }
}
