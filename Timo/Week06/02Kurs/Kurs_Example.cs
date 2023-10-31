using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timo.Week06._01Person;

namespace Timo.Week06._02Kurs
{
    public class Kurs_Example
    {
        public static void Start()
        {
            Kurs K1 = new Kurs("Programmieren für Anfänger", new DateTime(2023, 11, 01), 75, 250, new Person(180, 25, "Lukas", 70));
            Console.WriteLine(K1);
        }
    }
}
