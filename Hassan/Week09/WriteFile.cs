using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hassan.Week09
{
    public class WriteFile
    {

        public static void Start()
        {
            using (StreamWriter sw = new StreamWriter("C:\\Users\\DCV\\Source\\Repos\\CodingCampus_2023.09.VZ.Dornbirn\\Hassan\\Week09\\Hello.txt"))
            {
                sw.WriteLine("Hello World!!5451");

            }

           
        }

    }
}
