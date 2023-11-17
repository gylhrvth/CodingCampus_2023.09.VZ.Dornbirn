using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week06.Listen
{
    internal class ListCreate
    {
        private static Random random = new Random();

        public static void Start()
        {

            //Liste create
            List<int> list = ListCreated();
            //Liste print
            Print(list);
            Console.WriteLine("===" +
                "=========================================");
            Console.WriteLine();

            //Zählen der geraden Zahlen:
            int EvenCount = CountEvenNumber(list);
            Console.WriteLine("The List have {0} even Numbers", EvenCount);
            Console.WriteLine("");

            //Suche nach der kleinsten Zahl
            int min = NumberMin(list);
            Console.WriteLine("");

            //Suche nach der größten Zahl
            int max = NumberMax(list);
            Console.WriteLine("");

            //Sortiere die Elemente absteigend
            //Print(list);
            SortListDesc(list);
            Print(list);
            Console.WriteLine("");

            //Lösche alle ungeraden Zahlen
            Console.WriteLine("Delete Odd Numbers: ");
            //Print(list);
            DeleteOddNummbers(list);
            Print(list);

        }

        public static void Print(List<int> values)
        {
            Console.WriteLine("[{0}]", string.Join(", ", values));
        }


        private static List<int> ListCreated()
        {
            List<int> values = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                values.Add(random.Next(0, 100));
            }
            return values;

            //Console.WriteLine("[{0}]", string.Join(", ", values));
        }


        //private static

        public static int CountEvenNumber(List<int> values)
        {
            int countEvenNumber = 0;

            for (int i = 0; i < values.Count; i++)
            {
                if (values[i] % 2 == 0)
                {
                    countEvenNumber++;
                }
            }


            return countEvenNumber;
        }


        private static int NumberMin(List<int> values)
        {
            int min = Int32.MaxValue;

            for (int i = 0; i < values.Count; i++)
            {
                if (values[i] < min)
                {
                    min = values[i];
                }
            }
            Console.WriteLine("The min is: {0}", min);
            return min;
        }

        private static int NumberMax(List<int> values)
        {
            int max = Int32.MinValue;

            for (int i = 0; i < values.Count; i++)
            {
                if (values[i] > max)
                {
                    max = values[i];
                }
            }
            Console.WriteLine("The max is: {0}", max);
            return max;
        }

        private static void SortListDesc(List<int> values)
        {
            Console.WriteLine("Sorted List Desc:");
            for (int i = 0; i < values.Count; i++)
            {
                for (int j = 0; j < values.Count - i - 1; j++)
                {
                    if (values[j] < values[j + 1])
                    {
                        int temp = values[j];
                        values[j] = values[j + 1];
                        values[j + 1] = temp;
                    }
                }
            }
        }

        private static void DeleteOddNummbers(List<int> values)
        {
            for (int i = 0; i < values.Count; i++)
            {
                if (values[i] % 2 == 1)
                {
                    values.RemoveAt(i);
                    i--;
                }
            }
        }


    }
}
