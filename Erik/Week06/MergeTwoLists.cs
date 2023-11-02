using System;
using System.Runtime.CompilerServices;

namespace Erik.Week06
{
    public class MergeTwoLists
    {
        private static Random randomNumber = new Random();
        private List<int> _Values; 
        public static void Start()
        {
            List<int> RandomList1 = CreateRandomList(10, 1, 100);
            int maxx = GetStaticMaximum(RandomList1);


            MergeTwoLists mtl = new MergeTwoLists(20);
            int maxx2 = mtl.GetMaximum();
        }

        public MergeTwoLists(int size)
        {
            _Values = CreateRandomList(size, 0, 100);
        }

        private static List<int> CreateRandomList(int size, int min, int max)
        {
            List<int> RandomList = new List<int>();
            for (int i = 0; i < size; i++)
            {
                RandomList[i] = randomNumber.Next(min, max);
            }
            return RandomList;
        }

        public static int GetStaticMaximum(List<int> values)
        {
            return -123;
        }

        public int GetMaximum()
        {
            return -124;
        }
    }
}
