using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week09.InputOutput
{
    internal class Write
    {
        public static void Start()
        {
            Console.Write("Enter something you want to be in a txt file and type 'Ende' if you are done: ");
            bool end = true;
            while (end == true)
            {
                string input = Convert.ToString(Console.ReadLine());

                while (!input.Contains("Ende"))
                {
                    string saveslot = input;
                }

                if (input.Contains("Ende"))
                {
                    using (StreamWriter sw = new StreamWriter("C:\\Users\\nila\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Niklas\\Week09\\InputOutput\\InputText.txt"))
                    {
                        sw.WriteLine(input);
                    }
                    end = false;
                }
                else
                {
                    Console.Write("Type 'Ende' when you are done: ");
                }

            }
        }
    }

}

