using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static Jovo.Week04.ConsoleInput;

namespace Jovo.Week05
{
    internal class String
    {
        public static void Start()
        {


             
               string[] names = new string[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Öli", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };

               BubbleSortAscending(names);
               Console.WriteLine("Ascending");
               Console.WriteLine("===============================");
               PrintArray(names);

               Console.WriteLine("===============================");
               Console.WriteLine("===============================");

               BubbleSortDescending(names);
               Console.WriteLine("Descending");
               Console.WriteLine("===============================");
               PrintArray(names);

               Console.WriteLine("===============================");

               BubbleSortLexikographishA(names);
               Console.WriteLine("Lexiographisch Ascending");
               Console.WriteLine("===============================");
               PrintArray(names);

               Console.WriteLine("==============================");

               BubbleSortLexikographishD(names);
               Console.WriteLine("Lexiographisch Descending");
               Console.WriteLine("==============================");
               PrintArray(names);

               Console.WriteLine("==============================");

               int mynumber = ReadNumber("Wähle 1 für BubbleSortAscending  oder 2 für BubbleSortDescending");

               BubbleSortStringExtended(names , (mynumber == 1));
               Console.WriteLine("BubbleSortStringExtended");
               Console.WriteLine("==============================");
               BubbleSortStringExtended(names, true); 

               CharIndex(names , 2);
               Console.WriteLine("CharIndex");
               Console.WriteLine("==============================");
               PrintArray(names);

               Console.WriteLine("==================================");
               Console.WriteLine(names[0][0]);
               Console.WriteLine("=======================");
               


               Console.WriteLine("Hallo");

               string reverse= StringReverse("Hallo"); // nicht benutzen
               Console.WriteLine(reverse);

        }


       public static void BubbleSortAscending(string[] arr)
       {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j].Length > arr[j + 1].Length)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
       }



        public static void PrintArray(string[] arr)
        {
            foreach ( string s in arr)
            {
                Console.WriteLine(s);
            }
        }


        public static void BubbleSortDescending(string[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j].Length < arr[j + 1].Length)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }


        public static void BubbleSortLexikographishA(string[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (string.Compare(arr[j], arr[j + 1]) > 0)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

        }

        public static void BubbleSortLexikographishD(string[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (string.Compare(arr[j], arr[j + 1]) < 0)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

        }


        public static void BubbleSortStringExtended(string[] arr, bool ascending)
        {
           if (ascending)
           {
               BubbleSortAscending(arr);
           }
           else
           {
                BubbleSortDescending(arr);
           }
        }


        public static void CharIndex(string[] arr, int Index)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j][Index] > arr[j + 1][Index])
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }


        }

        public static string StringReverse(string text)
        {

            char[] chararr =  text.ToCharArray();
            int n = chararr.Length;

          
            Array.Reverse(chararr);

            return new string(chararr);


        }



        public static void StringReversenew(string text)
        {
            char[] charrarr = text.ToCharArray();
            int n = charrarr.Length;
            for (int i = 0; i < n/2; i++)
            {
                char temp = charrarr[i];
                charrarr[i] = charrarr[n - 1 - i];
                charrarr[n - 1 - i] = temp;


            }
        }


       

    }
}
