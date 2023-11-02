using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week06.Listen
{
    internal class ListCreate
    {
        private static Random random = new Random();

        public static void Start()
        {

            //Liste create
            List<int> list = ListCreated();

            //Liste print
            Print(list);


            //min Index
            int min = NumberMin(list);


        }

        public static void Print(List<int> values)
        {
            Console.WriteLine("[{0}]", string.Join(", ", values));
        }


        private static List<int> ListCreated()
        {
            List<int> values = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                values.Add(random.Next(0, 100));
            }
            return values;

            //Console.WriteLine("[{0}]", string.Join(", ", values));
        }


        //private static


        private static int NumberMin (List<int> values)
        {
            int min = Int32.MaxValue;
            for (int i = 0; i<values.Count; i++)
            {
                if (values[i] < min)
                {
                    min = values[i];
                }
            }
            Console.WriteLine("The min is: {0}", min);
            return min;
        }

}
}
