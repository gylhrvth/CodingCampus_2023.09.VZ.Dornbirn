using System;
namespace Mohammed.Week06.CreateAList
{
    public class ListEvaluation
    {
        private static Random rand = new Random();
        public static void Start()
        {

            List<int> values = CreateList(20, 100);

            PrintList(values);

            Console.WriteLine("============================");
            Console.WriteLine("Gerader Zahlen: {0}", CountEven(values));
            Console.WriteLine("============================");
            Console.WriteLine("finde kleisten Zahl: {0}", GetMinValue(values));
            Console.WriteLine("============================");
            Console.WriteLine("finde Größten Zahl:{0}", GetMaxValue(values));
            Console.WriteLine("============================");
            BubbleSort(values);
            PrintList(values);
            Console.WriteLine("============================");
            RemoveAllOddNumbers(values);
            PrintList(values);

            Console.WriteLine("============================");
            List<int> result = SortMergeList(values, values);
            PrintList(result);
            






        }

        public static List<int> CreateList(int size, int bound)
        {
            List<int> values = new List<int>();

            for (int i = 0; i < size; i++)
            {
                values.Add(rand.Next(10, bound));//!!!
            }
            return values;
        }

        public static void PrintList(List<int> values)
        {
            Console.Write("[");
            for (int i = 0; i < values.Count; i++)
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }
                Console.Write(values[i]);
            }
            Console.WriteLine("]");

        }

        public static int CountEven(List<int> values)
        {
            int count = 0;
            for (int i = 0; i < values.Count; i++)
            {
                if (values[i] % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        public static int GetMinValue(List<int> values)
        {
            int min = values[0];
            for (int i = 0; i < values.Count; i++)
            {
                if (values[i] < min)
                {
                    min = values[i];
                }
            }

            return min;
        }

        public static int GetMaxValue(List<int> values)
        {
            int max = values[0];
            for (int i = 0; i < values.Count; i++)
            {
                if (values[i] > max)
                {
                    max = values[i];
                }
            }

            return max;
        }

        //public static double CalcAvarage(List<int> values)
        //{
        //    return ;
        //}

        public static void BubbleSort(List<int> values)
        {
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


        public static void RemoveAllOddNumbers(List<int> values)
        {
            for (int i = 0; i < values.Count; i++)
            {
                if (values[i] % 2 != 0)
                {
                    values.RemoveAt(i);
                    i--;
                }
            }


        }


        public static List<int> SortMergeList(List<int> list1, List<int> liste2)
        {
            Console.WriteLine("sortedMergeList3");
            int i = 0;
            int j = 0;

            List<int> result = new List<int>();

            while (i < list1.Count && j < liste2.Count)
            {
                if (list1[i] < liste2[i])
                {
                    result.Add(list1[i]);
                    i++;

                }
                else
                {
                    result.Add(liste2[j]);
                    j++;
                }
            }

            while (i < list1.Count)
            {
                result.Add(list1[i]);
                i++;
            }

            while (j < liste2.Count)
            {
                result.Add(liste2[j]);
                j++;
            }
            return result;

        }


       


       

        





    }
}

