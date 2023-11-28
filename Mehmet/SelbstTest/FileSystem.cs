using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.SelbstTest
{
    internal class FileSystem
    {
        public static void Start()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            FileInfo fileInfo = new FileInfo(currentDirectory);
            //Console.WriteLine(fileInfo.Name);
            var currentDirectoryInfo = new DirectoryInfo(currentDirectory);
            string currentDirectoryRoot = currentDirectoryInfo.Parent.Parent.Parent.FullName;
            //Console.WriteLine(currentDirectoryInfo.Name+" : "+currentDirectoryRoot.Length);
            string[] children = Directory.GetFiles(currentDirectoryRoot);
            //Console.WriteLine(currentDirectoryRoot);
            //foreach (var child in children)
            //{
            //    FileInfo fileInfo2 = new FileInfo(child);
            //    Console.Write("     " + fileInfo2.Name + "   ");
            //    Console.WriteLine(fileInfo2.Length);
            //}

            Console.WriteLine(currentDirectoryRoot);
            PfadUndSo(currentDirectoryRoot,"---");
        }

        public static void PfadUndSo(string myDirectory,string depth) 
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

            //Console.WriteLine(myDirectory);
            string[] children = Directory.GetDirectories(myDirectory);
            string[] files = Directory.GetFiles(myDirectory);
            foreach ( var file in files )
            {
                FileInfo fileInfo = new FileInfo(file);
                Console.Write(depth + fileInfo.Name+" : : :  "); Console.WriteLine(fileInfo.Length+" Bits");
                if (fileInfo.Length > biggestFille1InBits)
                {
                    biggestFille1InBits = fileInfo.Length;
                    biggestFile1 = fileInfo.Name;
                }
                else if (biggestFille2InBits < fileInfo.Length && biggestFille2InBits < biggestFille1InBits)
                {
                    biggestFille2InBits = fileInfo.Length;
                    biggestFile2 = fileInfo.Name;
                }




            }

            //Console.WriteLine("oooo");
            if (biggestFille1InBits > int.MinValue + 1)
            {
                Console.WriteLine($"-------- 1.Größte datei : {biggestFile1} {biggestFille1InBits} ");
                if (biggestFille2InBits > long.MinValue)
                Console.WriteLine($"-------- 2.Größte datei : {biggestFile2} {biggestFille2InBits} ");
            }

            
            foreach ( var child in children)
            {
                Console.WriteLine("\n");
                PfadUndSo(child,depth +" "+ " └─>");
            }



        }



    }
}
