using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kerem.Week06;

namespace Kerem
{
    public class Kurse_TrainerExample
    {
        public static void Start()
        {
            Kurse_Trainer d = new Kurse_Trainer("Software Developer", new DateTime(2023,09,26), 500, 7850 ,new Person("Hassan", 21, 188, 80));

            Person trainer2 = new Person("Otto", 80, 150, 66);
            d.Trainer = trainer2;

            Console.WriteLine(d);


        }
    }
}
