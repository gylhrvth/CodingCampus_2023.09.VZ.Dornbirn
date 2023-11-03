using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week06._03List
{
    internal class ListeZusammenführen
    {
        public static List<int> MergeBothLists(List<int> list1, List<int> list2)
        {
            List<int> result = new List<int>();

            int i = 0;
            int j = 0;

            while (i < list1.Count && j < list2.Count)
            {
                if (list1[i] < list2[j])
                {
                    result.Add(list1[i]);
                    i++;
                }
                else
                {
                    result.Add(list2[j]);
                    j++;
                }
                
            }
            while (i < list1.Count)
            {
                result.Add(list1[i]);
                i++;
            }
            while (j < list2.Count)
            {
                result.Add(list2[j]);
                j++;
            }
          
            return result;
            
        }
    }

}
