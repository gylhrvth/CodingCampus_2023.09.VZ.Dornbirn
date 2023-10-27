using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Ressources;

namespace Ali.Week05
{
    internal class Strings
    {
        public static Random rand = new Random();
        public static void Start()
        {
            //String[] names = new String[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };
            //Console.WriteLine("Aufgabe 1 BubbleSort Aufsteigend");

            //BubbleSortAufsteigend(names, true);
            //Console.WriteLine(string.Join(",", names));

            //Console.WriteLine();
            //Console.WriteLine("Aufgabe 1 BubbleSort Descending");
            //BubbleSortDescending(names);
            //Console.WriteLine(string.Join(",", names));

            //Console.WriteLine();
            //Console.WriteLine("Aufgabe 1 BubbleSort Alphabetisch Aufsteigend");
            //BubbleSortAlphabet(names);
            //Console.WriteLine(string.Join(", ", names));

            //Console.WriteLine();
            //Console.WriteLine("Aufgabe 1 BubbleSort Alphabetisch Descending");
            //BubbleSortAlphabetDescending(names);
            //Console.WriteLine(string.Join(",", names));

            //Console.WriteLine();
            //Console.WriteLine("Aufgabe Bubblesort mit Strings und Character Index");
            //BubbleSortIndex(names);
            //Console.WriteLine(string.Join(",", names));

            //Console.WriteLine();
            //Console.WriteLine("Aufgabe Reversal");
            //Console.WriteLine();
            //Reversal();

            //Console.WriteLine();
            //Console.WriteLine("Aufgabe Randomize");
            //Console.Write("Willkommen zum Zufallsshuffle Programm!!!111");
            //Console.WriteLine("");
            //string text = Console.ReadLine();
            //Console.WriteLine(RandomizeString(text));


            //Console.WriteLine();
            //Console.WriteLine("Aufgabe Buchstaben zählen");

            //String s = StringRessources.getText();
            //Console.WriteLine(s);

            //int[] count = CountLetters(s);
            //PrintResult(count);
            //Console.WriteLine();

            Console.WriteLine("Aufgabe: Daten tabellarisch darstellen");
            Console.WriteLine();
            String[] firstName = { "Alfonso", "Beatrix-Eleonor", "Cecil", "Daniel", "Elmar" };
            String[] lastName =  { "Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma" };
            int[] age = { 40, 78, 5, 18, 81 };
            String[] place =  { "Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten" };
            float[] distanceFromCapital = { 0f, 654.4f, 12.457634366f, 120.0f, 119.9999f };















        }


        public static void BubbleSortAufsteigend(string[] names, bool ascending)
        {
            if (ascending == true)
                for (int i = 0; i < names.Length; i++)
                {
                    for (int j = 0; j < names.Length - 1 - i; j++)
                    {
                        if (names[j].Length > names[j + 1].Length)
                        {
                            string temp = names[j + 1];
                            names[j + 1] = names[j];
                            names[j] = temp;
                        }
                    }
                }
            else if (ascending == false)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    for (int j = 0; j < names.Length - 1 - i; j++)
                    {
                        if (names[j].Length < names[j + 1].Length)
                        {
                            string temp = names[j + 1];
                            names[j + 1] = names[j];
                            names[j] = temp;
                        }
                    }
                }

            }



        }
        public static void BubbleSortDescending(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < names.Length - 1 - i; j++)
                {
                    if (names[j].Length < names[j + 1].Length)
                    {
                        string temp = names[j + 1];
                        names[j + 1] = names[j];
                        names[j] = temp;
                    }
                }
            }

        }
        public static void BubbleSortAlphabet(String[] names)
        {
            string temp;

            for (int j = 0; j < names.Length - 1; j++)
            {
                for (int i = j + 1; i < names.Length; i++)
                {
                    if (names[j].CompareTo(names[i]) > 0)
                    {
                        temp = names[j];
                        names[j] = names[i];
                        names[i] = temp;
                    }
                }

            }
        }
        public static void BubbleSortAlphabetDescending(String[] names)
        {
            string temp;

            for (int j = 0; j < names.Length - 1; j++)
            {
                for (int i = j + 1; i < names.Length; i++)
                {
                    if (names[j].CompareTo(names[i]) < 0)
                    {
                        temp = names[j];
                        names[j] = names[i];
                        names[i] = temp;
                    }
                }

            }
        }
        public static string[] BubbleSortIndex(string[] names)

        {
            string temp;
            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < names.Length - 1; j++)
                {
                    if (names[j][2].CompareTo(names[j + 1][2]) > 0)
                    {
                        temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }
            return names;


        }
        public static void Reversal()
        {
            Console.WriteLine("Willkommen zum Reverseprogramm!!!111");
            string inputText = Console.ReadLine();

            char[] mychar = inputText.ToCharArray();

            Array.Reverse(mychar);

            Console.WriteLine(mychar);

        }


        public static string RandomizeString(string text)
        {
            char[] arr = text.ToCharArray();

            for (int i = 0; i < 3 * arr.Length; i++)
            {
                int posA = rand.Next(arr.Length);
                int posB = rand.Next(arr.Length);
                char temp = arr[posA];
                arr[posA] = arr[posB];
                arr[posB] = temp;
            }

            return new string(arr);
        }

        public static void PrintResult(int[] count)
        {
            for (int i = 0; i < count.Length; ++i)
            {
                if (count[i] > 0)
                {
                    char c = (char)i;
                    Console.WriteLine(c + " " + count[i]);
                }
            }
        }


        public static int[] CountLetters(string text)
        {
            int[] count = new int[char.MaxValue];
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                ++count[c];
            }

            return count;
        }

        public static void Tabelle(string firstName, string lastName, string place, int age, float distanceFromCapital)
        {
            Console.WriteLine(firstName);
            
        }

    }
}


