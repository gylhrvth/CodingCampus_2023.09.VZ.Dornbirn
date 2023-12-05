
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Org.BouncyCastle.Bcpg.Attr.ImageAttrib;

namespace Gheorghe.Week08
{
    internal class FileStreamRead
    {
        public static void Start()
        {
            string path = @"C:\Users\DCV\source\repos\CodingCampus_2023.09.VZ.Dornbirn\Gheorghe\Week01\HelloWorld.cs";

            // Datei lesen
            string text = ReadTextFile(path);

            // Text ausgeben
            Console.WriteLine(text);
        }





        public static string ReadTextFile(string path)
        {
            // Datei öffnen
            using (StreamReader reader = new StreamReader(path))
            {
                // Text lesen
                return reader.ReadToEnd();
            }
        }
    }
}
