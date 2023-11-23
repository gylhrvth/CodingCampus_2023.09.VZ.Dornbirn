using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.FileSystem
{
    internal class AufgabeDateienUndOrdnerAnzeigen
    {
        public static void Start()
        {         

            string path = Directory.GetCurrentDirectory();

            //Console.WriteLine(dir);

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            directoryInfo = directoryInfo.Parent.Parent.Parent.Parent;


            foreach (DirectoryInfo p in directoryInfo.GetDirectories())
            {
                Console.WriteLine("Ordner: " + p.Name);

            }
            foreach (FileInfo f in directoryInfo.GetFiles())
            {

                Console.WriteLine($"\t --> FileName = {f.Name,-30}   FileGröße = {f.Length,-8} Bites");
            }
        }
    }
}
