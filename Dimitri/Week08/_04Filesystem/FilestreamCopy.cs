using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week08._04Filesystem
{
    internal class FilestreamCopy
    {
        public static void Main()
        {
            string source = @"/Users/dimit/Source/Repos/test.txt";
            string dest1 = @"/Users/dimit/Source/Repos/testcopy.txt";
            string dest2 = @"/Users/dimit/Source/Repos/testcopyUpper.txt";
            CopyFile(source, dest1);
            CopyFileToUpperCase(source, dest2);
        }



        public static string ReadFile(string path)
        {
            string textToCopy = "";
            using (FileStream fs = File.OpenRead(path))
            {
                byte[] b = new byte[fs.Length];
                UTF8Encoding temp = new UTF8Encoding(true);
                int readLen;
                while ((readLen = fs.Read(b, 0, b.Length)) > 0)
                {
                    textToCopy = temp.GetString(b, 0, readLen);
                }
            }


            return textToCopy;
        }

        public static void WriteFile(string path, string stringToWrite)
        {
            using (FileStream fs = File.OpenWrite(path))
            {
                byte[] b = new byte[fs.Length];
                UTF8Encoding temp = new UTF8Encoding(true);
                b = temp.GetBytes(stringToWrite);
                fs.Write(b, 0, b.Length);
            }
        }

        public static void CopyFile(string source, string dest)
        {
            WriteFile(dest, ReadFile(source));
        }

        public static void CopyFileToUpperCase(string source, string dest)
        {
            WriteFile(dest, ReadFile(source).ToUpper());
        }
    }
}
