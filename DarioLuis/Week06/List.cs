using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Week06
{
    public class List
    {
        public static void Start()
        {
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(random.Next(0, 99));
            }
        }
    }
}
