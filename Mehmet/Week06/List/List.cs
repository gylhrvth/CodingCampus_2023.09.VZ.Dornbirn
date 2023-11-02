using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week06.List
{
    internal class List
    {

        public static Random rand = new Random();

        public static void Start()
        {

            List<int> value = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                value.Add(rand.Next(100));               
            }
            Console.WriteLine(string.Join(",",value));


            Console.Write("Gerade Zahlen: ");
            foreach (int element in value)
            {
                if (element % 2 == 0)
                {
                    Console.Write(element+", ");
                }
            }
            Console.WriteLine();


            Console.Write("Ungerade Zahlen: ");
            foreach (int element in value)
            {
                if (element % 2 == 1)
                {
                    Console.Write(element + ", ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("Max value: "+value.Max());
            Console.WriteLine("Min value: "+value.Min());


            for (int i = 0;i < value.Count; i++)
            {
                for (int j = 0;j < value.Count;j++)
                {
                    if (value[i] > value[j])
                    {
                        int temp = value[i];
                        value[i] = value[j];
                        value[j] = temp;
                    }

                }
                
            }

            Console.WriteLine(string.Join(",", value));


            Console.WriteLine("Remove");
            foreach (int element in value)
            {
                if (element % 2 == 1)
                {
                    value.Remove(element);

                }
                Console.Write(element+", ");
                
            }


            







        }









    }
}
