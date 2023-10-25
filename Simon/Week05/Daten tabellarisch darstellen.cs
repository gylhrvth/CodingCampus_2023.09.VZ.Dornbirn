using Simon.Week03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week05
{
    internal class Daten_tabellarisch_darstellen
    {
        public static void Start()
        {
            string[] firstName = { "Alfonso", "Beatrix-Eleonor", "Cecil", "Daniel", "Elmar" };
            string[] lastName = { "Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma" };
            int[] age = { 40, 78, 5, 18, 81 };
            string[] place = { "Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten" };
            float[] distanceFromCapital = { 0f, 654.4f, 12.457634366f, 120.0f, 119.9999f };

            string[][] table = Twodarr(1 + firstName.Length, 5);
            AddColumn(table, 0, "First name", firstName);
            AddColumn(table, 1, "Last name", lastName);
            AddColumn(table, 2, "Age", age);
            AddColumn(table, 3, "Place", place);
            AddColumn(table, 4, "Distance", distanceFromCapital);


            Console.WriteLine("| {0} |", firstName);
        }

        public static void printDaten(string[] firstName, string[] lastName, int[] age, string[] place, float[] distanceFromCapital)
        {
            Console.WriteLine("{0, -15}|{1, -15}|{2, -15}|{3, -15}|{4, -15}", "first Name", "last Name", "age", "place", "distance From Capital");
            Console.WriteLine("================================================================================================================");

        }

        public static void Print2darr(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("|| {0,20} ", arr[i][j]);
                }
                Console.WriteLine("|");
            }
        }
        public static string[][] Twodarr(int row, int col)
        {
            string[][] arr = new string[row][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new string[col];
                for (int j = 0; j < arr[i].Length; j++)
                {





                    //if (j == 0)
                    //{
                    //    arr[i][j] = firstName[j];
                    //}
                    //if (j == 1)
                    //{
                    //    arr[i][j] = lastName[j];
                    //}
                    
                }
            }
            return arr;
        }

        public static void AddColumn(string[][] table, int collumn, string headline, string[] values)
        {
            table[0][collumn] = headline;
            for (int i = 0;i < values.Length; i++)
            {
                table[1 + i][collumn] = values[i];
            }
        }

        public static void AddColumn(string[][] table, int collumn, string headline, int[] values)
        {
            table[0][collumn] = headline;
            for (int i = 0; i < values.Length; i++)
            {
                table[1 + i][collumn] = string.Format("{0}", values[i]);
            }
        }

        public static void AddColumn(string[][] table, int collumn, string headline, float[] values)
        {
            table[0][collumn] = headline;
            for (int i = 0; i < values.Length; i++)
            {
                table[1 + i][collumn] = string.Format("{0:N1}", values[i]);
            }
        }

        // mit forbzw foreach alle werte durchgehen und länge anschauen und wenn länger dann längeren wert übernehmen als Ergebnis
        public static int GetmaxString(string[] input)
        {
            UebungenString.BubbleSortasc(input);
            return input[input.Length - 1].Length;
        }
        public static int GetmaxInt(int[] input)
        {
            Sortieralgorithmen.BubbleSortasc(input);
            return input[input.Length - 1];
        }
        public static float Getmaxfloat(float[] input)
        {
            BubbleSortasc(input);
            float result = input[input.Length - 1];
            int resultnew = (int)result;
            return resultnew;
        }
        public static float[] BubbleSortasc(float[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j + 1], arr[j]) = (arr[j], arr[j + 1]);
                    }
                }
            }
            return arr;
        }





    }
}
