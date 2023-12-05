using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week09.FileSystem
{
    public class ReadFile
    {
        public static void Start()
        {
            using (StreamReader sr = new StreamReader("C:\\Users\\DCV\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Patrick\\Week09\\FileSystem\\Hello.txt"))
            {
                string line = sr.ReadLine();
                while(line != null)
                {
                    Console.WriteLine("sr1 = " + line);
                    line = sr.ReadLine();
                }
            }

            using (StreamReader sr2 = new StreamReader("C:\\Users\\DCV\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Patrick\\Week09\\FileSystem\\FileStreamWrite.txt"))
            {
                string line = sr2.ReadLine();
                while(line != null)
                {
                    Console.WriteLine("sr2 = " + line);
                    line = sr2.ReadLine();
                }
            }

            
        }

    }
}
