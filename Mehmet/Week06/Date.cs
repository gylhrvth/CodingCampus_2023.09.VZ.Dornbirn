using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week06
{
    internal class Date
    {
        public static void Start()
        {
            ExampleWhenAndWhere();





        }


        public static void ExampleWhenAndWhere()
        {
            DateTime dateTime = DateTime.Now;          
            CultureInfo austria = new CultureInfo("de-AT");


            Console.WriteLine(dateTime.ToString("dd.MM.yyyy"));



        }



    }
}
