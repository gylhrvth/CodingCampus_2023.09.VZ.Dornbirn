using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week09.FileSystem
{
    internal class FileCopy
    {
        public static void Start()
        {
            Copy("C:\\Users\\DCV\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Patrick\\Week09\\FileSystem\\Hello.txt", "C:\\Users\\DCV\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Patrick\\Week09\\Hello.txt");
        }

        public static void Copy(string source, string destination)
        {
            using (StreamReader sr = new StreamReader(source))
            {
                string line = sr.ReadLine();

                using (StreamWriter sw = new StreamWriter(destination))
                {
                    sw.WriteLine(line);
                    line = sr.ReadLine();
                }
            }
        }


    }
}
