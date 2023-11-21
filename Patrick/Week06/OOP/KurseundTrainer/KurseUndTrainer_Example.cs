using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Patrick.Week06.OOP.PersonOne;

namespace Patrick.Week06.OOP.KurseundTrainer
{
    internal class KurseUndTrainer_Example
    {
        public static void Start()
        {
            KurseUndTrainer b1 = new KurseUndTrainer("Softwaredeveloper", new DateTime(2023, 9, 26), 500, 8000, new PersonOne.Person("Gyula", 44, 172, 80));
            Console.WriteLine(b1);

            Console.WriteLine();

            KurseUndTrainer b2 = new KurseUndTrainer("Chefkoch", new DateTime(1990, 12, 26), 100, 1250, new PersonOne.Person("Lukas", 35, 190, 75));
            Console.WriteLine(b2);
        }


    }
}
