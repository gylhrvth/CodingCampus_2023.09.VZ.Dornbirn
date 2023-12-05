using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selina.Week08.Filesystem
{
    public class WriteFile
    {
        public static void Start()
        {
            using (StreamWriter sw = new StreamWriter("C:\\Users\\wpfsebr\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Selina\\Week08\\Filesystem\\Hello.txt"))
            {
                sw.WriteLine("Hello World!");
            }
        }
    
    }
}
