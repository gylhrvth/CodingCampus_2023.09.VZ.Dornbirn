using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mehmet.Week06.Person;
using Mehmet.Week06.List;

namespace Mehmet.Week06.Person
{
    internal class PersonList
    {        
 
        


        public static void Start()
        {
            List<int> values1 = List.List.CreateRandomList(5);
            List<string> abc = new List<string>();
            abc.Add("A"); abc.Add("B"); abc.Add("C"); abc.Add("D"); abc.Add("E"); abc.Add("F");

            Console.WriteLine(string.Join(" ,",values1));
            Console.WriteLine("Min value: " + MinInAIntList(values1));
            Console.WriteLine("Max value: "+MaxInAIntList(values1));
            Console.WriteLine("Avg value: " + AvgInAIntList(values1));
            List.List.PrintList(SortListDes(values1));
            List.List.PrintList(SortListAsc(values1));
        }
        

        public static double MinInAIntList(List<int> list) 

        {
            int x = int.MaxValue;
            for (int i = 0;i<list.Count;i++)
            {
                if (list[i] < x)
                {
                    x = list[i];
                }
            }
            return x;
        }
        public static double MaxInAIntList(List<int> list)
        {
            int x = int.MinValue;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > x)
                {
                    x = list[i];
                }
            }
            return x;
        }
        public static double AvgInAIntList(List<int> list)
        {
            double x = 0;
            for (int i = 0;i < list.Count; i++)
            {
                x += list[i];
            }
            x = x/list.Count;
            return x;
        }
        public static List<int> SortListDes(List<int> list)
        {
            for (int i = 0;i<list.Count ; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[i] > list[j])
                    {
                        int temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            return list;
        }
        public static List<int> SortListAsc(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[i] < list[j])
                    {
                        int temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            return list;
        }


    }
}
