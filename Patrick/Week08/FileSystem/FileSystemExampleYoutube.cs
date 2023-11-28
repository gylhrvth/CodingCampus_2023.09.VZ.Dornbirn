using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.FileSystem
{
    public class FileSystemExampleYoutube
    {
        public static void Start()
        {
        //    string rootPath = @"C:\Users\DCV\source\repos\CodingCampus_2023.09.VZ.Dornbirn\Patrick\Week01";

        //    string[] dirs = Directory.GetDirectories(rootPath,"*", SearchOption.AllDirectories);

        //    foreach (string dir in dirs)
        //    {
        //        Console.WriteLine(dir);
        //    }

        //    var files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);

        //    foreach (string file in files)
        //    {
        //        Console.WriteLine(file);
        //        Console.WriteLine(Path.GetFileName(file));
        //        Console.WriteLine(Path.GetFileNameWithoutExtension(file));
        //        Console.WriteLine(Path.GetFullPath(file));
        //        Console.WriteLine(Path.GetDirectoryName(file));
        //        var info = new FileInfo(file);
        //        Console.WriteLine($"{Path.GetFileName(file)}: {info.Length} bytes");
        //    }

            string newPath = @"C:\Users\DCV\source\repos\CodingCampus_2023.09.VZ.Dornbirn\Patrick\Week11";

            bool directoryExists = Directory.Exists(newPath);

            if (directoryExists)
            {
                Console.WriteLine("The directory exists");
            }
            else
            {
                Console.WriteLine("The diracotry does not exists");
                Directory.CreateDirectory(newPath);
            }

        }

    }
}
