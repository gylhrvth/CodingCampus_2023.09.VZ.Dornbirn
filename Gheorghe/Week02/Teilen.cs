using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe.Week02
{
    internal class Teilen
    {
        public static void Start()
        {
            teilenUndHerrschen(20);
        }


        public static void teilenUndHerrschen(int count)
        {
            int five = 5;
            double fived = 5.0;

            for (int i = 0; i <=count ; i++)  
            {
                Console.Write(i + " / " + five + " = ");
                Console.Write(i / five);
                Console.WriteLine();
                Console.Write($"{i} / {fived:0.0} = ");
                Console.Write(i / fived);
                Console.WriteLine();
            }
        }
    }
}
