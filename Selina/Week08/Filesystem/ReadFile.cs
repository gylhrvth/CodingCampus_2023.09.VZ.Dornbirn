using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selina.Week08.Filesystem
{
    public class ReadFile
    {
        public static void Start()
        {
            using (StreamReader sr = new StreamReader("C:\\Users\\wpfsebr\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Selina\\Week08\\Filesystem\\Hello.txt"))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
            }
        }
    }
}
