using Cemal.Week06.NmsPerson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Cemal.Week06.Kurse_und_Trainer
{
    public class KursMain
    {

        public static void Start()
        {
            Kurs k = new Kurs("Software Developer", new DateTime(2023,09,26), 500, 7850,new Person("Hassan", 21, 188, 80));
            Person trainer2 = new Person("Otto", 80, 150, 66);
            k.Trainer = trainer2;

            Console.WriteLine(k);
        }
    }
}
