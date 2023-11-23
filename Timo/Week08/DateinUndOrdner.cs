using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week08
{
    public class DateinUndOrdner
    {
        public static void Start()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string[] children = Directory.GetFiles(currentDirectory);
            var currentDirectoryInfo = new DirectoryInfo(currentDirectory);
            string projectRootDirectory = currentDirectoryInfo.Parent.Parent.Parent.Parent.FullName;
            Console.WriteLine("Project root directory: " + projectRootDirectory);
            string[] directoryChildren = Directory.GetDirectories(projectRootDirectory);
            string[] directoryChildrenFiles = Directory.GetFiles(projectRootDirectory);
            foreach (var directory in directoryChildren)
            {
                FileInfo fileInfo = new FileInfo(directory);
                DirectoryInfo info = new DirectoryInfo(directory);
                if (Directory.Exists(info.FullName))
                {
                    Console.WriteLine(info.Name);
                }
            }
            foreach (var directory in directoryChildrenFiles)
            {
                FileInfo fileInfo = new FileInfo(directory);
                DirectoryInfo info = new DirectoryInfo(directory);
                if (File.Exists(fileInfo.FullName))
                {
                    Console.WriteLine(fileInfo.Name + " " + Math.Round(ConvertToKB(fileInfo.Length)) + "KB") ;
                }
            }
        }
        public static float ConvertToKB(long sizeInByte)
        {
            return sizeInByte / 1024.0f;
        }
    }

}
