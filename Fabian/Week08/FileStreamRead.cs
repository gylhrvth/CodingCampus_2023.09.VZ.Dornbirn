
using System.Text;

namespace Fabian.Week08
{
    public class FileStreamRead
    {
        public static void Start()
        {
            string path = "C:\\Users\\fakr\\Documents\\textnis.txt";
            ReadTxt(path);
        }

        public static void ReadTxt(string path)
        {
            using(FileStream fs = File.OpenRead(path)) 
            {
                byte[] b = new byte[1];
                UTF8Encoding temp = new UTF8Encoding(true);
                int readLen;
                while ((readLen = fs.Read(b, 0, b.Length)) > 0)
                {
                    Console.WriteLine(temp.GetString(b, 0, readLen));
                    Thread.Sleep(100);
                }
            }    
        }
    }
}
