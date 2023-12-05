using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week09
{
    internal class FileStreamRead
    {
        public static void Start()
        {
            //string path1 = Directory.GetCurrentDirectory();
            //string path2 = "C:\\Users\\DCV\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Mehmet\\Week09\\";
            //var fileStream = new FileStream(path1) ;
            //Console.WriteLine(path1);
            //fileStream.Read(path1, 0, path1.Length);
            ////File.OpenRead(path2);


            using (StreamReader sr = new StreamReader("C:\\Users\\DCV\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Mehmet\\Week09\\Text1.txt"))
            {
                string fileContentss = sr.ReadLine();
                while (fileContentss != null)
                {
                    Console.WriteLine(fileContentss);
                    fileContentss = sr.ReadLine();
                }
            }





        }

    }
}
