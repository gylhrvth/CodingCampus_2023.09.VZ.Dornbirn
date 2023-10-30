using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hassan.Week05
{
    public class Bubblerehearsal
    {
        public static void Start()
        {
            string[] names = { "Hassan", "David", "Niklas", "Gheorge", "Eren", "Ali", "Ceccon", "Mohammed" };

               

            Console.WriteLine("Unsrotier: >>>>>>");
            //Array Unsorted
            PrintArray(names);


            Console.WriteLine("===================================");
            //Sortieren
            BubbleSortDesc(names,false);
            Console.WriteLine("Sortiert: >>>>>>");
            //Sortiert
            PrintArray(names);


        }

        public static void PrintArray(string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        public static string[] BubbleSortLexi(string[] arr)
        {
            int steps = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (string.Compare(arr[j], arr[j +1]) > 0)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                    steps++;
                }
            }
            return arr;

        }

        public static string[] BubbleSortDesc(string[] names, bool ascending)
        {
            if (ascending == true)
            {
                int steps = 0;
                for (int i = 0; i < names.Length - 1; i++)
                {
                    for (int j = 0; j < names.Length - 1 - i; j++)
                    {
                        if (names[j].Length > names[j + 1].Length)
                        {
                            string temp = names[j];
                            names[j] = names[j + 1];
                            names[j + 1] = temp;
                        }
                        steps++;
                    }
                }
            }else if(!ascending)
            {
                int steps = 0;
                for (int i = 0; i < names.Length - 1; i++)
                {
                    for (int j = 0; j < names.Length - 1 - i; j++)
                    {
                        if (names[j].Length < names[j + 1].Length)
                        {
                            string temp = names[j];
                            names[j] = names[j + 1];
                            names[j + 1] = temp;
                        }
                        steps++;
                    }
                }
            }
            return names;

        }

    }
}
