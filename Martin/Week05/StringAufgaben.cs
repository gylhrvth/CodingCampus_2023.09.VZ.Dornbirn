using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Ressources;

namespace Martin.Week05
{
    internal class StringAufgaben
    {
        public static void StartStringAufgaben()
        {
            String[] names = new String[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };

            BubbleSortAufsteigend(names);
            //PrintArray(names);

            //BubbleSortAbsteigend(names);
            //PrintArray(names);

            //BubbleSortNachBuchstabeAufsteigend(names);
            //PrintArray(names);

            //BubbleSortNachBuchstabeAbsteigend(names);
            //PrintArray(names);


            //BubbleSortMitStringsExtended(names, true);

            //BubbleSortMitStringUndCharacterIndex(names, 1, false);
            //PrintArray(names);

            Reverse();
            //Randomzie("Gib dein word ein das dieses word mit den buchstabe ein zufälliges wort gibt");

            String[] firstName = { "Alfonso", "Beatrix-Eleonor", "Cecil", "Daniel", "Elmar" };
            String[] lastName = { "Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma" };
            int[] age = { 40, 78, 5, 18, 81 };
            String[] place = { "Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten" };
            float[] distanceFromCapital = { 0f, 654.4f, 12.457634366f, 120.0f, 119.9999f };

            Tabelle2d(2, 3);
            
        }
        public static void BubbleSortAufsteigend(string[] names)
        {
            for(int i = 0; i < names.Length; i++)
            {
                for(int j = 0; j < names.Length - 1; j++)
                {
                    if (names[j].Length > names[j + 1].Length)
                    {
                        string name = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = name;
                    }
                }
            }
        }
        public static void BubbleSortAbsteigend(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < names.Length - 1; j++)
                {
                    if (names[j].Length < names[j + 1].Length)
                    {
                        string name = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = name;
                    }
                }
            }
        }
        public static void BubbleSortNachBuchstabeAufsteigend(string[] names)
        {

            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < names.Length - 1; j++)
                {

                    if (names[j].CompareTo(names[j + 1]) > 0)
                    {
                        string name = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = name;
                    }

                }
            }
        }
        public static void BubbleSortNachBuchstabeAbsteigend(string[] names)
        {

            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < names.Length - 1; j++)
                {

                    if (names[j].CompareTo(names[j + 1]) < 0)
                    {
                        string name = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = name;
                    }

                }
            }
        }
        public static void BubbleSortMitStringsExtended(string[] names,bool aufsteigen)
        {

            if(aufsteigen)
            {
                BubbleSortNachBuchstabeAufsteigend(names);
            }
            else
            {
                BubbleSortNachBuchstabeAbsteigend(names);
            }
        }
        public static void BubbleSortMitStringUndCharacterIndex(string[] names, int pos, bool aufsteigend) 
        {
            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < names.Length - 1; j++)
                {

                    if (aufsteigend == (names[j][pos].CompareTo(names[j + 1][pos]) > 0))
                    {
                        string name = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = name;
                    }

                }
            }
        }
        public static void Reverse()
        {
            Console.WriteLine("Gib ein Wort ein");
            string input = Console.ReadLine();

            Char[] FirstInput = input.ToCharArray();
            
            Array.Reverse(FirstInput);

            string ReverseWord = new String(FirstInput);


            Console.WriteLine(ReverseWord);
        }
        public static void Randomzie(string msg) 
        {
            Console.WriteLine(msg);
            string input = Console.ReadLine();

            Char[] RandomLetters = input.ToCharArray();
            Random ran = new Random();

            for(int anzahl  = 0; anzahl < RandomLetters.Length; anzahl++)
            {
                int ranompos = ran.Next(RandomLetters.Length);
                char temp = RandomLetters[anzahl];
                RandomLetters[anzahl] = RandomLetters[ranompos];

                RandomLetters[ranompos] = temp;

            }

            string RandomWord = new String(RandomLetters);

            Console.WriteLine(RandomLetters);

        }
        public static void BuchstabenZeahlen()
        {
            String t = Ressources.StringRessources.getText();
            //int[] array =   
        }



        public class CountLetters
        {
            public static void Start()
            {
                String s = StringRessources.getText();
                Console.WriteLine(s);

                int[] count = countLetters(s);
                PrintResult(count);

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

            public static int[] countLetters(string text)
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

        public static string[][] Tabelle2d(int row, int colms)
        {
            String[][] arr = new string[row][];

            for(int i = 0;i < row; ++i)
            {
                arr[i] = new string[colms];
            }

            return arr;
        }
        
        public static String[] PrintArray(String[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            
            return array;
        }
    }
}
