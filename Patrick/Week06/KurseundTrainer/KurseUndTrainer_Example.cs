using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Patrick
{
    internal class KurseUndTrainer_Example
    {
        public static void Start()
        {
            KurseUndTrainer b1 = new KurseUndTrainer("Softwaredeveloper", "26.09.2023", 500, 8000, new Person(178,40,"Guyla",80));
            Console.WriteLine(b1);

            Console.WriteLine();

            KurseUndTrainer b2 = new KurseUndTrainer("Chefkoch", "26.12.1990", 100, 1250, new Person(190, 35, "Lukas", 75));
            Console.WriteLine(b2);
        }

        
    }
}
