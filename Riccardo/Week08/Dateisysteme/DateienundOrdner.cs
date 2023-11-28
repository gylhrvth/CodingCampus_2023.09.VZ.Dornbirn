using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riccardo.Week08.Dateisysteme
{
    internal class DateienundOrdner
    {

        public static void Start()
        {
            string currentDirecotry = Directory.GetCurrentDirectory();
            Console.WriteLine(currentDirecotry);

            Console.WriteLine("Files");

            string[] children = Directory.GetFiles(currentDirecotry);

            foreach (var child in children)
            {
                FileInfo fileInfo = new FileInfo(child);

                Console.WriteLine(fileInfo.Name + " ");
            }  




        }


























        /*
        public static void Start()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine(currentDirectory);

            Console.WriteLine("Files");

            string[] children = Directory.GetFiles(currentDirectory);

            foreach (var child in children)
            {
                FileInfo fileInfo = new FileInfo(child);

                Console.WriteLine(fileInfo.Name + " " + Math.Round(ConvertToMByte(fileInfo.Length), 2) + "mb");
            }

            Console.WriteLine("Children Directories");


        }
        public static float ConvertToMByte(long sizeInByte)
        {
            return sizeInByte / 1024.0f / 1024;
        }
        */
    }
}
