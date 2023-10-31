using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week06._03List
{
    public class List
    {
        public static Random random = new Random();

        public static List<int> CreateListRandomFirst()
        {
            List<int> list = new List<int>();

            for(int i = 0; i < 20; i++)
            {
                list.Add(random.Next(0, 100));
            }

            return list;
        }

        public static void PrintList(List<int> list)
        {
            bool first = true;
            Console.Write("[ ");
            foreach (int item in list)
            {
                if (first)
                {
                    Console.Write(item);
                    first = false;
                }
                Console.Write(", " + item);
            }

            Console.Write(" ]");
            Console.WriteLine();
        }

        public static List<int> CreateRandomList(int count, int min, int max)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < count; i++)
            {
                list.Add(random.Next(min, max));
            }

            return list;

        }



    }
}
