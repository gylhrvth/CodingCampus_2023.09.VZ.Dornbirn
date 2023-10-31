using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week06.Kurs
{
    internal class KursExample
    {
        public static void Start()
        {
            Kurs k1 = new Kurs("Titel", "0.0.0", 0, 0, "Trainer");
            Console.WriteLine("__________________");
            k1.Titel = "Digital Campus Vorarlberg";
            k1.Start = "26.09.2023";
            k1.Stunden = 453;
            k1.Preis = 6000;
            Console.WriteLine("___________________");
            k1.Trainer = Person.PersonExample.Start();
            Console.WriteLine("___________________");
        }
    }
}
