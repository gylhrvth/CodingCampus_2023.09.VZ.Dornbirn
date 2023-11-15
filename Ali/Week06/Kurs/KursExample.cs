using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Week06.Kurs
{
    public class KursExample
    {
        public static void Start()
        {
            Kurs1 k1 = new Kurs1("Software Dev", "26.September.2023", 459, 7890, "Gyula");

            Console.WriteLine(k1.ToString());
        }
    }

}
