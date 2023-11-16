using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ali.Week06.Liste1;
using static Ali.Week06.ListeEx;

namespace Ali.Week06.Liste
{
    public class MergeList
    {
        public static void MergeList1(List<int> list)

        {
            PrintList(list);

            List<int> list1 = CreateRandomList(19);
            List<int> list2 = CreateRandomList(15);

            int i = 0;
            int j = 0;
            int temp = 0;
            while (list1[i] < list2[j])
            {
                temp = list1[i];
                i++;
            }
             if (list1[i] > list2[j])
            {
                temp = list2[j];
                    j++; 
            }
            while (list1.Count < 0)
            {
                temp = list2[i];
            }


        }


    }
}


