using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sven.Week09
{
    internal class Writefile
    {

        public static void Start()
        {

            using (StreamWriter sw = new StreamWriter("C:\\Users\\juens\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Sven\\Week09\\Hello.txt"))
            {

                sw.WriteLine("Hello World!!");

            }
        }

    }
}
