using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week08.Files.StreamFiles
{
    public class StreamMain
    {
        public static void Start()
        {


           WriteFile();
           ReadFile();
            
        
        }

        public static void WriteFile()
        {
            string path = "C:\\Users\\Martin\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Martin\\Week08\\Hello.txt";

            using (StreamWriter sw = new StreamWriter(path)) //erstellt textdokument
            {
                sw.WriteLine("lol"); // schreibt einmal rein 

            }
     
        }

        public static void ReadFile()
        {
            using(StreamReader sr = new StreamReader("C:\\Users\\Martin\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Martin\\Week08\\Hello.txt")) //angeben was er lesen soll
            {
                string line = sr.ReadLine();

                while(line != null)
                {
                    Console.WriteLine(line);
                    line  = sr.ReadLine();
                }

            }
        }
    }
}
