using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Jovo.Week09
{
    internal class FileCopy
    {
        public static void Start()
        {//Pfad woher ich die daten bekommen und wohin die daten gehen
            CopyTo("", "");
        }

        public static void CopyTo(string source, string destination)
        {
            using (StreamReader rs = new StreamReader(source))
            {
                using (StreamWriter sw = new StreamWriter(destination))
                {
                    string line = rs.ReadLine();

                    while (line != null)
                    {
                        sw.WriteLine(line);
                        line = rs.ReadLine();
                    }
                }
            }
        }
    }
}
