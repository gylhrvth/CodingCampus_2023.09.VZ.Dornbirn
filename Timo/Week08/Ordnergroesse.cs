using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week08
{
    public class Ordnergroesse
    {
        public static void Start()
        {
            string path = "C:\\Users\\aau27722\\source\\Repos\\CodingCampus_2023.09.VZ.Dornbirn\\Timo\\Week08\\053Museum";
            string[] files = Directory.GetFiles(path);
            long sumFileSize = 0;
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                if (fileInfo.Exists)
                {
                    sumFileSize += fileInfo.Length;
                }
            }
            Console.WriteLine("Der Ordner im Verzeichnis {0} hat insgesamt {1} Kilobyte",path, Math.Round(ConverttoKB(sumFileSize), 2));
        }
        public static float ConverttoKB(long sizeInByte)
        {
            return sizeInByte / 1024.0f;
        }
    }
}
