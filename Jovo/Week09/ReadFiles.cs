using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week09
{
    internal class ReadFiles
    {

        public static void Start()
        {
            using(StreamReader sr = new StreamReader("C:\\Users\\DCV\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Jovo\\Week09\\Hello.txt"))
            {
                string line = sr.ReadLine();
                while(line != null)
                {
                    Console.WriteLine(line);
                    //damit die nächste zeile auch liest
                    line = sr.ReadLine();
                }
            }
        }
    }
}
