using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.SelbstTest
{
    internal class FileSystem
    {
        public static void Start()
        {

            string path = "C:\\Users\\DCV\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Mehmet\\Mehmet.csproj";
            string currentDirectory = Directory.GetCurrentDirectory();
            FileInfo fileInfo = new FileInfo(currentDirectory);
            //Console.WriteLine(fileInfo.Name);
            //var currentDirectoryInfo = new DirectoryInfo(path);
            //string currentDirectoryRoot = currentDirectoryInfo.Parent.FullName;
            //Console.WriteLine(currentDirectoryInfo.Name+" : "+currentDirectoryRoot.Length);
            DirectoryInfo rootFolder = new DirectoryInfo(currentDirectory).Parent.Parent.Parent;
            //Console.WriteLine(currentDirectoryRoot);
            //foreach (var child in children)
            //{
            //    FileInfo fileInfo2 = new FileInfo(child);
            //    Console.Write("     " + fileInfo2.Name + "   ");
            //    Console.WriteLine(fileInfo2.Length);
            //}

            Console.WriteLine(rootFolder);
            PfadUndSo(rootFolder, "---");
        }

        public static void PfadUndSo(DirectoryInfo myDirectory,string depth) 
        {
            string biggestFile1 = "";
            long biggestFille1InBits = long.MinValue;
            string biggestFile2 = "";
            long biggestFille2InBits = long.MinValue;
            string biggestFile3 = "";
            long biggestFille3InBits = long.MinValue;
            string biggestFile4 = "";
            long biggestFille4InBits = long.MinValue;
            string biggestFile5 = "";
            long biggestFille5InBits = long.MinValue;




            FileInfo[] files = myDirectory.GetFiles();  

            foreach (FileInfo file in files) 
            {
                Console.WriteLine($"{depth}  {file.Name}  : : :  {file.Length} bits");
                if (file.Length > biggestFille1InBits)
                {
                    biggestFille1InBits = file.Length;
                    biggestFile1 = file.Name;
                }
                if (file.Length < biggestFille1InBits && file.Length > biggestFille2InBits )
                {
                    biggestFille2InBits = file.Length;
                    biggestFile2 = file.Name;
                }
            }
            DirectoryInfo[] directoryInfo = myDirectory.GetDirectories();

            if (biggestFille1InBits > long.MinValue + 1)
            {
                Console.WriteLine($"---------------------------------------- 1.Größte datei : {biggestFile1} {biggestFille1InBits} bits");
                if (biggestFille2InBits > long.MinValue)
                    Console.WriteLine($"---------------------------------------- 2.Größte datei : {biggestFile2} {biggestFille2InBits} bits");
            }



            foreach (DirectoryInfo file in directoryInfo)
            {
                Console.WriteLine(depth + file.Name);
                PfadUndSo(file, depth + " └─>");
            }






           

            //Console.WriteLine(myDirectory);
            //string[] children = Directory.GetDirectories(myDirectory);
            //string[] files = Directory.GetFiles(myDirectory);

            //string name = Directory.GetCurrentDirectory();


            //foreach ( var file in files )
            //{
            //    FileInfo fileInfo = new FileInfo(file);


            //    Console.Write(depth + fileInfo.Name+" : : :  "); Console.WriteLine(fileInfo.Length+" Bits");
            //    if (fileInfo.Length > biggestFille1InBits)
            //    {
            //        biggestFille1InBits = fileInfo.Length;
            //        biggestFile1 = fileInfo.Name;
            //    }
            //    else if (biggestFille2InBits < fileInfo.Length && biggestFille2InBits < biggestFille1InBits)
            //    {
            //        biggestFille2InBits = fileInfo.Length;
            //        biggestFile2 = fileInfo.Name;
            //    }




            //}

            //Console.WriteLine("oooo");
            

            //foreach ( var child in children)
            //{
            //    //Console.WriteLine("\n");
            //    PfadUndSo(child,depth +" "+ " └─>");
            //}



        }



    }
}
