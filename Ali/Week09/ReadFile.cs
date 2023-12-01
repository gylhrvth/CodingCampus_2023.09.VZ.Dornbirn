using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Week09
{
    public class ReadFile
    {
        public static void Start()
        {
            ReadTextFile("C:\\Users\\DCV\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Ali\\Week09\\Text1234.txt");
        }
        public static void ReadTextFile(string filepath)
        {
            try
            {
                using (FileStream fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read))
                {

                    using (StreamReader reader = new StreamReader(fileStream, Encoding.UTF8))
                    {

                        string text = reader.ReadToEnd();
                        Console.WriteLine("Kerem ist ein Lappen");
                        Console.WriteLine(text);
                    }
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Fehler beim Lesen der Datei: {ex.Message}");

            }
                
                

            }
    }
}



