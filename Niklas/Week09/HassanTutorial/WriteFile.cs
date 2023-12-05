using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week09.HassanTutorial
{
    internal class WriteFile
    {
        public static void Start()
        {
            using (StreamWriter sw = new StreamWriter("C:\\Users\\nila\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Niklas\\Week09\\HassanTutorial\\Hello.txt"))
            {
                sw.WriteLine("Hello World!");
                sw.WriteLine("zweite Zeile");
            }
        }
    }
}
