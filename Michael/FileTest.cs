using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael
{
    internal class FileTest
    {
        public static void Start()
        {
            Console.WriteLine("name of file?");

            string? input = Console.ReadLine();

            if (File.Exists("C:\\Users\\michi\\" + input))
            {
                Console.WriteLine("contents:");

                Console.WriteLine(File.ReadAllText("C:\\Users\\michi\\" + input));

                Console.WriteLine("\nDo you want to delete it?");

                string? yn = Console.ReadLine();

                yn = yn.ToLower();

                if (yn == "y" || yn == "yes")
                {
                    Console.WriteLine("file will be deleted");
                    File.Delete("C:\\Users\\michi\\" + input);
                }
                else
                {
                    Console.WriteLine("file will not be deleted");
                }


            }
            else
            {
                Console.WriteLine("doesn't exist yet. will be created, what do u wanna write in it?");

                var file = File.CreateText("C:\\Users\\michi\\" + input);

                file.Write(Console.ReadLine());

                file.Close();
            }
        }
    }
}
