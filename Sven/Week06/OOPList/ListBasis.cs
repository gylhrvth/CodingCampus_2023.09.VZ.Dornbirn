using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sven.Week06.OOPList
{
    internal class ListBasis
    {

        private static Random rand = new Random();

        public static void CreateRandomList()
        {
            List<int> value = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                value.Add(rand.Next(0, 100));

            }
            Console.WriteLine(string.Join(", ", value));

        }

    }
}
