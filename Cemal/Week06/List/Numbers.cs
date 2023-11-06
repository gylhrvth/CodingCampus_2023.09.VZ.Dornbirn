using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week06.NmsList
{
    public class Numbers
    {
        private static Random random = new Random();

        public static void Start()
        {
            List<int> list = RandomNumbers(20, 100);
            PrintList(list);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Es gibt {0} gerade Zahlen", CountEvenNumbers(list));
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("die kleinste Zahl ist {0}", GetMinimum(list));
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("die größte Zahl ist {0}", GetMaximum(list));
            Console.WriteLine();

            Console.WriteLine();
            SortList(list);
            Console.WriteLine("Sortiert");
            PrintList(list);
            Console.WriteLine();
            
            Console.WriteLine();
            RemoveOddNumbers(list);
            Console.WriteLine("nur gerade Zahlen: ");
            PrintList(list);




        }


        public static List<int> RandomNumbers(int size, int bound)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < size; i++)
            {
                result.Add(random.Next(bound));
            }

            return result;
        }

        public static void PrintList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
                if (i < list.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

        public static int CountEvenNumbers(List<int> list)
        {
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        public static int GetMinimum(List<int> list)
        {
            int MinNumber = Int32.MaxValue;

            for (int i = 0; i < list.Count; i++)
            {
                MinNumber = Math.Min(MinNumber, list[i]);
            }

            return MinNumber;
        }

        public static int GetMaximum(List<int> list)
        {
            int MaxNumber = int.MinValue;

            for (int i = 0; i < list.Count; i++)
            {
                MaxNumber = Math.Max(MaxNumber, list[i]);
            }
            return MaxNumber;
        }

        public static List<int> SortList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++) 
            {
                for (int j = 0;j < list.Count -1 -i; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j + 1];
                        list[j + 1] = list[j];
                        list[j] = temp;
                    }
                }
            }
            return list;
        }

        public static void RemoveOddNumbers(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 != 0)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
        }

    }
}
