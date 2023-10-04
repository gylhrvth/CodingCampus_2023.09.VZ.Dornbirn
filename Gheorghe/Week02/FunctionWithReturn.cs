using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe.Week02
{
    internal class FunctionWithReturn
    {
        public static void Start()
        {
            Console.WriteLine(Add(3, 2));

            int c = Add(5, 4);
            Console.WriteLine(c);
        }


        public static int Add(int a, int b)
        {
            int result = a + b;

            return result;
        }

    }
}
    

