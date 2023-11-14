//using System;
//namespace Mohammed.Week06
//{
//    public class List
//    {
//        private static Random rand = new Random();
//        public static void Start()
//        {
//            List<int> values = new List<int>();

//            for (int i = 0; i < 100; i++)
//            {
//                values.Add(rand.Next(1, 100));
//            }

//            Console.WriteLine("Count: {0}", values.Count);
//            Console.WriteLine("Capacity :{0}", values.Capacity);

//            Console.WriteLine("[{0}]", string.Join(" ", values));


//            for (int i = 0; i < values.Count; i++)
//            {
//                Console.WriteLine("{0}. is {1}", i, values[i]);
//            }

//            foreach(int j in values)
//            {
//                Console.WriteLine("Value: {0}", j);
//            }

//            values.RemoveAt(0);
//            Console.WriteLine("[{0}]", string.Join(" ", values));

//            Console.WriteLine("Ist 20 inside " + values.Count());

//        }
//    }
//}
