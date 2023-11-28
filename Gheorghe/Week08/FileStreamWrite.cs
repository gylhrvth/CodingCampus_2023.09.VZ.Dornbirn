using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Gheorghe.Week08
{
    internal class FileStreamWrite
    {

        public static void Start()
        {
            using (FileStream fileStream = new FileStream("output.txt", FileMode.Create))
            { 
                string input = " ";
                while (input != "ende")
                {
                    input = Console.ReadLine();

                    byte[] buffer = Encoding.UTF8.GetBytes(input);

                    fileStream.Write(buffer, 0, buffer.Length); 
                }
            }
        }
    }
}
