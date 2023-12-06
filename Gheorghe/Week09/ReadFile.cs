using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe.Week09
{
    internal class ReadFile
    {
        public static void Start()
        {
            using (StreamReader sr = new StreamReader("C:\\Users\\DCV\\Source\\Repos\\CodingCampus_2023.09.VZ.Dornbirn\\Gheorghe\\Week09\\Hello.txt"))
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
