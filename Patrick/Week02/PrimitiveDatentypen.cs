using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week02
{
    internal class PrimitiveDatentypen
    {
        public static void start()
        {
            summe();
        }
        
        public static void summe()
        {
            int num = 20;

            for( int i = 0; i <=30; i++)
            {
                num += i;
                Console.Write(num + " + ");
            }
        }





    }
}
