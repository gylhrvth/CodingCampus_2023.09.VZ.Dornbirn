using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riccardo.Week09
{
    internal class WriteFile
    {
        public static void Start()
        {
            using (StreamWriter sw = new StreamWriter("C:\\Users\\aau22705\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Riccardo\\Week09\\Hello.txt"))
            {
                sw.WriteLine("Hello World!!5451");
            }
        } 
    }
}
