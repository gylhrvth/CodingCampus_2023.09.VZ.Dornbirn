using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe.Week09
{
    public class WriteFile
    {

        public static void Start()
        {
            using (StreamWriter sw = new StreamWriter("C:\\Users\\DCV\\Source\\Repos\\CodingCampus_2023.09.VZ.Dornbirn\\Gheorghe\\Week09\\Hello.txt"))
            {
                sw.WriteLine("Hello World");
                sw.WriteLine("Zweite Zeile");
                sw.WriteLine("Hallo Gheorghe");
            }
        }
    }
}
