using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Jovo.Week01.Methoden;



namespace Jovo.Week04
{
    public class Menü
    {

        public static void Start()
        {




            int readNumberMenue = ReadNumberMenue("Welcome!", "Was soll ich dir zeichnen", "Christbaum", "Quader", "Rhombus", "Wie groß soll es sein?", "welche symbole soll ich benutzen");
        }







        public static int ReadNumberMenue(String stage1, String Question, String drawing1, String drawing2, String drawing3, String asksize, String asksymbol)
        {
            Console.WriteLine(stage1);
            Console.WriteLine(Question);
            Console.WriteLine("1 für = " + drawing1);
            Console.WriteLine("2 für = " + drawing2);
            Console.WriteLine("3 für = " + drawing3);
            Console.WriteLine();




            while (true) 
            {
                try
                {
                    String input = Console.ReadLine();
                    int myNumber = Convert.ToInt32(input);


                    if (myNumber == 1)
                    {




                    }




                }


                catch
                {

                }

            }


        }


    }
}
