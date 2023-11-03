using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe.Week06.List
{


    public class ListEvaluator
    {
        public static Random random = new Random();

        public static void Start()
        {

            List<int> list = CreateList(20);


            foreach (int value in list)
            {
                Console.WriteLine(value);
            }

        }


        public static List<int> CreateList(int size)

        {
            List<int> list = new List<int>();
            for (int i = 0; i < size; i++)
            {
                list.Add(random.Next(1, 100));

            }
            return list;
        }

        

    }
}
