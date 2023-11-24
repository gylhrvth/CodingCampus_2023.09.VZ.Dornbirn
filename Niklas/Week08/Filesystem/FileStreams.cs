using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week08.Filesystem
{
    public class Files3
    {
        public Files3()
        {

        }

        public static void Start()
        {
            CopyFile("/tmp/a", "/tmp/a_to_uppercase");
            CopyFileToUppercase("/tmp/a", "/tmp/a_to_uppercase");
        }

        public static void CopyFile(string source, string dest)
        {
            if (!File.Exists(source))
            {
                throw new FileNotFoundException();
            }

            if (File.Exists(dest))
            {
                File.Delete(dest);
            }

            FileStream? input = null;
            FileStream? output = null;
            byte[] buffer = new byte[1024];
            try
            {
                input = File.OpenRead(source);
                output = File.OpenWrite(dest);
                int read = 0;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    output.Write(buffer, 0, read);
                }
            }
            finally
            {
                Close(input);
                Close(output);
            }
        }

        public static void CopyFileToUppercase(string source, string dest)
        {
            if (!File.Exists(source))
            {
                throw new FileNotFoundException();
            }

            if (File.Exists(dest))
            {
                File.Delete(dest);
            }

            FileStream? input = null;
            FileStream? output = null;
            byte[] buffer = new byte[1024];
            try
            {
                input = File.OpenRead(source);
                output = File.OpenWrite(dest);
                int read = 0;
                UTF8Encoding uTF8 = new UTF8Encoding(true);
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    string text = uTF8.GetString(buffer, 0, read);
                    string toUpper = text.ToUpper();
                    byte[] outBytes = uTF8.GetBytes(toUpper);
                    output.Write(outBytes, 0, outBytes.Length);
                }
            }
            finally
            {
                Close(input);
                Close(output);
            }
        }

        private static void Close(FileStream? fileStream)
        {
            try
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
            catch (Exception _)
            {
                //noop
            }
        }
    }
}
