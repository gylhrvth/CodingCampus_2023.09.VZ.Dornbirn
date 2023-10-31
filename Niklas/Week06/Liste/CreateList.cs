using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week06.Liste
{
    internal class CreateList
    {
        public static int Start()
        {
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                int a = random.Next(0, 100);
                Console.WriteLine(a);
            }
            return random.Next();
        }

    }
}
