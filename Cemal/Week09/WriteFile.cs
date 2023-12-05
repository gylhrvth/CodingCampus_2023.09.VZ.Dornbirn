using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week09
{
    public class WriteFile
    {
        public static void Start()
        {
            using (StreamWriter sw = new StreamWriter("C:\\Users\\wpfceko\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Cemal\\Week09\\Hello.txt"))
            {
                sw.WriteLine("Hello World!!");
                sw.WriteLine("Hassan El Patron!");
            }
        }
    }
}
