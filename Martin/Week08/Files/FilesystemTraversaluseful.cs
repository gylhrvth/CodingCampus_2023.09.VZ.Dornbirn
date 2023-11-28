using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week08.Files
{
    public class FilesystemTraversaluseful  //TraverUsefulInterface
    {
        public static void Start()
        {



        }

        public static void GoToPath(string path)
        {

            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            Console.WriteLine("Name: " + directoryInfo.FullName);
        }


    }

}
