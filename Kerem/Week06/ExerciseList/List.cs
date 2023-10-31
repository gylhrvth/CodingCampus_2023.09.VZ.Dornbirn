using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem
{
    internal class List
    {
        private static Random rand = new Random();

        public static void Start()
        {
            List<int> values = new List<int>();

            for( int i = 0; i < 20; i++ )
            {
                values.Add(rand.Next(0, 100));
            }
            Console.WriteLine("[{0}]", string.Join(", ", values));

        }
    }
}
