using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe.Week08
{
    internal class FileStreamCopy
    {
        public static void Start()
        {
            // Datei kopieren
            CopyFile("source.txt", "target.txt");
        }


        public static void CopyFile(string sourcePath, string targetPath)
        {
            try
            {
                // Datei öffnen
                using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open))
                using (FileStream targetStream = new FileStream(targetPath, FileMode.Create))
                {
                    // Datei kopieren
                    byte[] buffer = new byte[1024];
                    int bytesRead;

                    while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        targetStream.Write(buffer, 0, bytesRead);
                    }
                }
            }
            catch (IOException e)
            {
                // Fehler ausgeben
                Console.WriteLine(e.Message);
            }
        }



      
    }
}
