using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week08.Obj_Selbsttest.Filesystem
{
    internal class Aufgabe4
    {
        public static void Start()
        {
            IsExisting(false);
            BigestFile();
        }
        public static bool IsExisting(bool exist)
        {
            Console.Write("Please enter your current files path (to your name folder): ");
            var input = Console.ReadLine();
            //C:\Users\nila\source\repos\CodingCampus_2023.09.VZ.Dornbirn\Niklas

            var getDir = Directory.GetCurrentDirectory();
            DirectoryInfo dir = new DirectoryInfo(getDir);
            var root = dir.Parent.Parent.Parent.FullName;

            if (input != root)
            {
                throw new DirectoryNotFoundException();
                exist = false;
            }
            else if (input == root)
            {
                Console.WriteLine(input);
                exist = true;
            }
            return exist;
        }
        public static void BigestFile()
        {
            var getDir = Directory.GetCurrentDirectory();
            DirectoryInfo dir = new DirectoryInfo(getDir);

            string folder = dir.Parent.Parent.Parent.FullName;

            string[] directoryChildren = Directory.GetDirectories(folder);
            Bubblesort(directoryChildren);

            foreach (var files in directoryChildren)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(files);
                Console.WriteLine(dirInfo.FullName.Length);
                foreach (var files2 in files)
                {
                    //DirectoryInfo dirInfo2 = new DirectoryInfo(files2);
                }
            }
        }
        public static void Bubblesort(string[] names)
        {
            for (int i = 0; i < names.Length - 1; i++)
            {
                for (int j = 0; j < names.Length - 1 - i; j++)
                {
                    if (names[j].Length < names[j + 1].Length)
                    {
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }
        }
    }
}
