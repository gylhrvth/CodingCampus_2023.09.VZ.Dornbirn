using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sven.Week06.OOPList
{
    internal class Mergesort
    {

        public static List<int> MergeSort(List<int> list1, List<int> list2)
        {
            List<int> newlist = new List<int>();

            while (list1.Count > 0 && list2.Count > 0)
            {
                if (list1.First() > list2.First())
                {
                    newlist.Add(list1.First());
                    list1.RemoveAt(0);
                }
                else
                {
                    newlist.Add(list2.First());
                    list2.RemoveAt(0);
                }
            }
            while (list1.Count > 0)
            {
                newlist.Add(list1.First());
                list1.RemoveAt(0);
            }
            while (list2.Count > 0)
            {
                newlist.Add(list2.First());
                list2.RemoveAt(0);
            }
            return newlist;

        }

    }
}
