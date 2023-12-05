using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week09.FileStream
{
    internal class FileStreamRead
    {
        public static void Start()
        {
            string path = "C:\\Users\\DCV\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Kerem\\Week09\\Hello.txt";
            string newpath = "C:\\Users\\DCV\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Kerem\\Week09\\HelloCopy.txt";
            Copy(path, newpath);

        }

        public static void ReadFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line = sr.ReadLine();
                while(line != null)
                {
                    line = sr.ReadLine();
                }
            }
        }
        public static void WriteFile(string newpath)
        {
            using (StreamWriter sw = new StreamWriter(newpath))
            {
                sw.WriteLine(sw);
            }

        }
    

        public static void Copy(string path, string newpath)
        {
            using(StreamReader sr = new StreamReader(path))
            {
                string read = sr.ReadToEnd();
                using(StreamWriter sw = new StreamWriter(newpath))
                {
                    sw.WriteLine(read);
                }



            }

        }
     
    }
}
