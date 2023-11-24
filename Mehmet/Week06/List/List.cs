using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Xml.Linq;

namespace Kerem.Week06.List
{
    internal class List
    {
        public static List<int> values1 = new List<int>();
        public static List<int> values2 = new List<int>();
       

        public static Random rand = new Random();

        public static void Start()
        {
            Console.WriteLine("CreateRandomList");
            values1 = CreateRandomList(20);
            PrintList(values1);
            Console.WriteLine("-------------------------\n");

            CountEvenNumbers(values1);
            Console.WriteLine("-------------------------\n");

            GetSmallest(values1);
            Console.WriteLine("-------------------------\n");

            GetBigest(values1);
            Console.WriteLine("-------------------------\n");

            SortListAsc(values1);
            Console.WriteLine("SortListAsc");
            PrintList(values1);
            Console.WriteLine("-------------------------\n");

            RemoveEven(values1);
            Console.WriteLine("RemoveEven");
            PrintList(values1);
            Console.WriteLine("-------------------------\n");

            values2 = CreateRandomList(20);
            Console.WriteLine("AddListInAList");
            PrintList(values1);
            PrintList(values2);
            List<int> values3 = AddListInAList(values1, values2);
            PrintList(values3);
            Console.WriteLine("-------------------------\n");

            values1 = CreateRandomList(5);
            values1.Sort();
            values2 = CreateRandomList(20);
            values2.Sort();
            PrintList(values1);
            PrintList(values2);
            List<int> values3byGyula = AddListInAListByGyula(values1, values2);
            PrintList(values3byGyula);
            Console.WriteLine("-------------------------\n");

        }

        public static List<int> CreateRandomList(int size)
        {
            List<int> values = new List<int>();
            for (int i = 0; i < size; i++)
            {
                values.Add(rand.Next(1, 100));
            }
            return values;
        }
        public static void PrintList(List<int> values)
        {
            Console.WriteLine(string.Join(",", values));
        }
        public static void CountEvenNumbers(List<int> values)
        {
            Console.Write("Gerade Zahlen: ");
            foreach (int element in values)
            {
                if (element % 2 == 0)
                {
                    Console.Write(element + ", ");
                }
            }
            Console.WriteLine();
        }
        public static int GetSmallest(List<int> values)
        {
            int minValue = values.Min();
            Console.WriteLine("min value: " + minValue);
            return values.Min();
        }
        public static int GetBigest(List<int> values)
        {
            int maxValue = values.Max();
            Console.WriteLine("max value: " + maxValue);
            return values.Max();
        }
        public static void SortListAsc(List<int> values)
        {
            for (int i = 0; i < values.Count; i++)
            {
                for (int j = 0; j < values.Count; j++)
                {
                    if (values[i] > values[j])
                    {
                        int temp = values[i];
                        values[i] = values[j];
                        values[j] = temp;
                    }
                }
            }
        }
        public static List<int> RemoveEven(List<int> values)
        {

            for (int i = 0; i < values.Count; i++)
            {
                bool end = true;
                while (end)
                {
                    if (values[i] % 2 == 1)
                    {
                        values.Remove(values[i]);
                    }
                    if (i == values.Count)
                    {
                        end = false;
                    }
                    else if (values[i] % 2 == 0)
                    {
                        end = false;
                    }
                }
            }
            return values;
        }
        public static List<int> AddListInAList(List<int> values1, List<int> values2)
        {

            List<int> newValues = new List<int>();

            for (int i = 0; i < values1.Count; i++)
            {
                for (int j = 0; j < values1.Count; j++)
                {
                    if (values1[i] < values1[j])
                    {
                        int temp = values1[i];
                        values1[i] = values1[j];
                        values1[j] = temp;
                    }
                }
            }
            for (int i = 0; i < values2.Count; i++)
            {
                for (int j = 0; j < values2.Count; j++)
                {
                    if (values2[i] < values2[j])
                    {
                        int temp = values2[i];
                        values2[i] = values2[j];
                        values2[j] = temp;
                    }
                }
            }

            bool end = true;
            bool end2 = true;
            
            while (end)
            {
                while (end2)
                    if (values1.Count > 0 && values2.Count > 0)
                    {
                        if (values1[0] == values2[0])
                        {
                            newValues.Add(values1[0]);
                            if (values1.Count > 0)
                            {
                                values1.Remove(values1[0]);
                            }
                            if (values1.Count == 0)
                            {
                                end2 = false;
                            }
                        }
                        else if (values1[0] < values2[0])                       
                        {
                            newValues.Add(values1[0]);
                            if (values1.Count > 0)
                            {
                                values1.Remove(values1[0]);
                            }
                            if (values1.Count == 0)
                            {
                                end2 = false;
                            }
                        }
                        else if (values2[0] < values1[0])
                        {
                            newValues.Add(values2[0]);                      
                            if (values2.Count > 0)
                            {
                                values2.Remove(values2[0]);
                            }
                            if (values2.Count == 0)
                            {
                                end2 = false;
                            }
                        }
                        else
                        {
                            end2 = false;
                        }
                    }   
                
                if (values1.Count  == 0 && values2.Count > 0)
                {

                    newValues.Add(values2[0]);
                    if (values2.Count > 0)
                    {
                        values2.Remove(values2[0]);
                    }
                    if (values2.Count == 0)
                    {
                        end = false;
                    }
                }
                if (values2.Count == 0 && values1.Count > 0)
                {
                    newValues.Add(values1[0]);
                    if (values1.Count > 0)
                    {
                        values1.Remove(values1[0]);
                    }
                    if (values1.Count == 0)
                    {
                        end = false;
                    }
                }
                if (values2.Count == 0 && values1.Count == 0)
                {
                    end = false;
                }
                else
                {
                    end = false;
                }
            }                    
            return newValues;
        }


        public static List<int> AddListInAListByGyula(List<int> values1, List<int> values2)
        {
            List<int> result = new List<int>();
            while (values1.Count > 0 && values2.Count > 0) { 
                if (values1[0] < values2[0])
                {
                    result.Add(values1[0]);
                    values1.RemoveAt(0);
                }
                else
                {
                    result.Add(values2[0]);
                    values2.RemoveAt(0);
                }
            }
            while (values1.Count > 0)
            {
                result.Add(values1[0]);
                values1.RemoveAt(0);
            }
            while (values2.Count > 0)
            {
                result.Add(values2[0]);
                values2.RemoveAt(0);
            }
            return result;
        }

    }
}