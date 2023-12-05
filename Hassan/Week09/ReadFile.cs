using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hassan.Week09
{
    public class ReadFile
    {
        public static void Start()
        {
            using(StreamReader sr = new StreamReader("C:\\Users\\DCV\\Source\\Repos\\CodingCampus_2023.09.VZ.Dornbirn\\Hassan\\Week09\\Hello.txt"))
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
