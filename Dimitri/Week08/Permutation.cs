using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week08
{
    internal class Permutation
    {
        public static void Main()
        {
            List<char> list = new List<char>() { 'A', 'B', 'C', 'D'};

            PermutationCharList(list, 0, list.Count - 1);
        }

        public static void PrintCharList(List<char> list)
        {
            Console.Write("{0}. ", count);
            foreach (char c in list)
            {
                Console.Write("{0}", c);
            }
            Console.WriteLine();
        }

        public static int count = 0;

        public static List<char> PermutationCharList(List<char> list, int indexBegin, int indexEnd)
        {
            if(indexBegin == indexEnd)
            {
                count += 1;
                PrintCharList(list);
            }
            for(int i = indexBegin; i <= indexEnd; i++)
            {
                SwapChar(list, indexBegin, i);
                PermutationCharList(list, indexBegin + 1, indexEnd);
                SwapChar(list, indexBegin, i);
            }
            return list;
        }

        public static List<char> SwapChar(List<char> list, int i, int j) 
        {
            char temp;
            temp = list[i];
            list[i] = list[j];
            list[j] = temp;
            return list;
        }

    }
}
