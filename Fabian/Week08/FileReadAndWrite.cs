using System.IO;
using System.Text;

namespace Fabian.Week08
{
    internal class FileReadAndWrite
    {
        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string file = @"C:\Users\fakr\Documents\textnis.txt";

            // method 
            try
            {
                using (FileStream fsw = File.OpenWrite(file))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("This is to test the OpenWrite method.\n");

                    fsw.Write(info, 0, info.Length);
                }

                //using (FileStream fs = File.OpenRead(file))
                //{
                //    byte[] b = new byte[1024];
                //    UTF8Encoding temp = new UTF8Encoding(true);
                //    int readLen;
                //    while ((readLen = fs.Read(b, 0, b.Length)) > 0)
                //    {
                //        Console.WriteLine(temp.GetString(b, 0, readLen));
                //    }
                //}
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
           
            
            // method 2

            string newText = "File.AppendAllText says hi\n";
            if (File.Exists(file))
            {
                File.AppendAllText(file, newText);
            }

            //if (File.Exists(file))
            //{
            //    string text = File.ReadAllText(file);
            //    Console.WriteLine(text);
            //}

            //method 3

            try
            {             
                using (StreamWriter sw = new StreamWriter(file, true))
                {
                    sw.WriteLine("StreamWriter.WriteLine says hello");
                }

                using (StreamReader sr = new StreamReader(file))
                {
                    string? data;
                    while ((data = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(data);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
