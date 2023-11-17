using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week06.Kurse_und_Trainer
{
    public class KurseUndTrainerMain
    {

        public static void Start()
        {
            KurseUndTrainer k1 = new KurseUndTrainer("Master",DateTime.Now, 500, 7850, new Person("Gyula", 40, 180,80));

            Console.WriteLine(k1);
            Console.WriteLine(k1.Stunden);


        }
    }
}
