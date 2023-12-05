using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riccardo.Week09
{
    internal class ReadFiles
    {
        public static void Start()
        {
            using (StreamReader sr = new StreamReader("C:\\Users\\aau22705\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Riccardo\\Week09\\Hello.txt"))
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
