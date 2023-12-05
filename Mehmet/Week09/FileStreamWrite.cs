using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week09
{
    internal class FileStreamWrite
    {
        public static void Start()
        {

            //String input = Console.ReadLine();
            //Console.WriteLine("your input is: " + input);


            var fileName = @"C:\Users\DCV\source\repos\CodingCampus_2023.09.VZ.Dornbirn\Mehmet\Week09\Text1.txt";

            using FileStream fs = File.OpenWrite(fileName);
            {
                var data = "falcon\nhawk\nforest\ncloud\nsky\nwawawawaw";
                byte[] bytes = Encoding.UTF8.GetBytes(data);

                fs.Write(bytes, 0, bytes.Length);
            }
        }
    }
}
