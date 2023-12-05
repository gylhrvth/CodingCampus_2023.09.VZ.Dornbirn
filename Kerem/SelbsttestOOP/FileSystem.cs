using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.SelbsttestOOP
{
    internal class FileSystem
    {
        public static void Start()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine("CurrentDirectory" + currentDirectory);

            var currentDirectoryInfo = new DirectoryInfo(currentDirectory);
            Console.WriteLine(currentDirectoryInfo.Name);

            foreach ( var file in currentDirectoryInfo.GetFiles() )
            {
                Console.WriteLine(file.Length);
            }

        }
    }
}
