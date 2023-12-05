using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.adventofcode
{
    public class Day_1
    {
        public static void Start()
        {
            string path = "C:\\Users\\BAU21982\\OneDrive - Julius Blum GmbH\\Advent of Code\\input.txt";
            Console.WriteLine(ReadTextFile1(path));

        }

        public static string ReadTextFile1(string filePath)
        {
            using (FileStream fileStream = File.OpenRead(filePath))
            using (StreamReader streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string fileContent = streamReader.ReadToEnd();
                return fileContent;
            }
        }


    }
}
