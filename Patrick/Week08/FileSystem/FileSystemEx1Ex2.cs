using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.FileSystem
{
    internal class FileSystemEx1Ex2
    {
        public static void Start()
        {

            string path = Directory.GetCurrentDirectory();
            var pathInfo = new DirectoryInfo(path);
            Console.WriteLine(path);
            string pathNew = pathInfo.Parent.Parent.Parent.Parent.FullName;
            //string week = pathNew + @"\Patrick\Week06\OOP\Zoo";
            //DirectoryInfo directoryInfo = new DirectoryInfo(week);

            //Console.WriteLine($"Die Summe der Filesgrößen im Ordner \"{directoryInfo.Parent.Name} {directoryInfo.Name}\" = " + CalcFolderSize(week) + " Bites groß");

            //Console.WriteLine(week);

            Console.WriteLine(pathNew);

            string[] pathDirectories = Directory.GetDirectories(pathNew);

            
            foreach (string folder in pathDirectories)
            {
                DirectoryInfo info = new DirectoryInfo(folder);

                Console.WriteLine(info.Name+" "+"size = " +CalcFolderSize(info.FullName));

               // Console.WriteLine(info.FullName);
            }
            //string[] fileInfo = Directory.GetFiles(week);

            //foreach (string file in fileInfo)
            //{
            //    FileInfo info = new FileInfo(file);
            //    Console.WriteLine($"\t ----> FileName = {info.Name,-15}  ||  FileSize = {info.Length,-4} Bites");
            //}
        }

        public static long CalcFolderSize(string path)
        {
           string[] files = Directory.GetFiles(path);

            long result = 0;
            foreach (string p in files)
            {
                FileInfo fileInfo = new FileInfo(p);
                result += fileInfo.Length;
            }
            return result;
        }
    }



}

