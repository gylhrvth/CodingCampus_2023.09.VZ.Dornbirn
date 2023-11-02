using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week06.Liste
{
    internal class ListSort
    {
        public static void Start()
        {
            int random = CreateList.Start();
            

            Console.WriteLine();
            StraightNumber(random);
        }
        public static void StraightNumber(int random)
        {
            if (random % 2 == 0)
            {
                Console.WriteLine(random);
            }
        }
    }
}
