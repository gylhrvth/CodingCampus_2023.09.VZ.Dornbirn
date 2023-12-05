using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sven.Week09
{
    internal class Readfile
    {
        public static void Start()
        {

            using (StreamReader sr = new StreamReader("C:\\Users\\juens\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Sven\\Week09\\"))
            {

                string line = sr.ReadLine();

                while (sr != null)
                {
                    Console.WriteLine(sr);
                    line = sr.ReadLine();
                }


            }

        }

    }
}
