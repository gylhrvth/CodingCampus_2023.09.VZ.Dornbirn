using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timo.Week03;

namespace Timo.Week05;

internal class StringSort
{
    public static Random random = new Random();
    public static void Start()
    {
        String[] names = new String[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };
        Console.WriteLine("Aufgabe 1+2:Bubblesort mit Strings");
        Console.WriteLine("sort length");
        PrintStringArray(BubbleSortStringLength(names, true));
        Console.WriteLine("================");
        PrintStringArray(BubbleSortStringLength(names, false));
        Console.WriteLine("===============================================================");
        Console.WriteLine("sort alphabeth");
        PrintStringArray(BubbleSortStringAtoZ(names, true));
        Console.WriteLine("================");
        PrintStringArray(BubbleSortStringAtoZ(names, false));

        Console.WriteLine("===============================================================");

        Console.WriteLine("Aufgabe 3: Bubblesort mit Strings und Character Index");
        PrintStringArray(BubbleSortStringAtoZIndex(names, true, 2));

        Console.WriteLine("===============================================================");

        Console.WriteLine("Aufgabe 4: Reverse:");
        Console.WriteLine(ReverseString("Hallo"));

        Console.WriteLine("===============================================================");

        Console.WriteLine("Aufgabe 5: Randomize:");
        Console.WriteLine(RandomString("HalloDuSchöner"));
    }
    //--------------------------------------------------------------
    public static void PrintStringArray(string[] arr)
    {
        for (int i = 0; i < arr.Length; ++i)
        {
            Console.WriteLine("{0}. = {1}", i, arr[i]);
        }
    }
    //--------------------------------------------------------------

    //Aufgabe 1+2: Bubblesort String + extended
    public static string[] BubbleSortStringAtoZ(string[] names, bool asc)
    {
        for (int i = names.Length; i > 1; i--)
        {
            for (int a = 0; a < i - 1; a++)
            {
                if (asc == names[a].CompareTo(names[a + 1]) > 0)
                {
                    string temp = names[a + 1];
                    names[a + 1] = names[a];
                    names[a] = temp;
                }
            }
        }
        return names;
    }

    public static string[] BubbleSortStringLength(string[] names, bool asc)
    {
        for (int i = names.Length; i > 1; i--)
        {
            for (int a = 0; a < i - 1; a++)
            {
                if (asc == names[a].Length > names[a + 1].Length)
                {
                    string temp = names[a + 1];
                    names[a + 1] = names[a];
                    names[a] = temp;
                }
            }
        }
        return names;
    }


    //-----------------------------------------------------------------------------------------------------------------------------------

    //Aufgabe 3: Bubblesort Index
    public static string[] BubbleSortStringAtoZIndex(string[] names, bool asc, int indexToBeSorted)
    {
        for (int i = names.Length; i > 1; i--)
        {
            for (int a = 0; a < i - 1; a++)
            {
                if (asc == names[a][indexToBeSorted].CompareTo(names[a + 1][indexToBeSorted]) > 0)
                {
                    string temp = names[a + 1];
                    names[a + 1] = names[a];
                    names[a] = temp;
                }
            }
        }
        return names;
    }


    //-----------------------------------------------------------------------------------------------------------------------------------

    //Aufgabe 4: Reverse
    public static string ReverseString(string input)
    {
        char[] chars = input.ToCharArray();
        char[] reverse = new char[chars.Length];
        for (int i = 0; i < chars.Length; i++)
        {
            reverse[reverse.Length -1 - i] = chars[i];
        }
        input = new string(reverse);
        return input;
    }


    //-----------------------------------------------------------------------------------------------------------------------------------

    //Aufgabe 5: Random
    public static string RandomString(string input)
    {
        char[] chars = input.ToCharArray();

        for (int i = 0; i < chars.Length;i++)
        {
            int o = random.Next(chars.Length);
            char temp = chars[i];
            chars [i] = chars[o];
            chars[o] = temp;
        }

        input = new string(chars);

        return input;
    }

    public static void 
}

