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
            Kurs k = new Kurs("titel", 1, 1, 1, );
            Console.WriteLine(k.Titel);

            k.Titel = "Apfelsaftladen";
            Console.WriteLine(k);
        }
    }
}
