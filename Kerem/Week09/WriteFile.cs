using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week09
{
    internal class WriteFile
    {
        public static void Start()
        {
            using (StreamWriter sw = new StreamWriter("C:\\Users\\DCV\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Kerem\\Week09\\Hello.txt"))
            {
                sw.WriteLine("Hello World");
                sw.WriteLine("second line");
                sw.WriteLine("third line");
            }
        }
    }
}
