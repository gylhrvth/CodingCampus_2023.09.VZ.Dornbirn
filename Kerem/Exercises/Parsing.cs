using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Exercises
{
    internal class Parsing
    {
        public static void main()
        {
            string myString = "15";
            string mySecondString = "15";

            int myNum = Int32.Parse(myString);
            int myNum2 = Int32.Parse(mySecondString);
            int resultInt = myNum + myNum2;
            string result = myString + mySecondString;


            Console.WriteLine(resultInt);
            

            string stringForfloat = "0.85";
            string stringForInt = "12345";

            float f = float.Parse(stringForfloat);
            int i = Int32.Parse(stringForInt);

            Console.WriteLine("Int = {0}, Float = {1}", i, f);
        }
    }
}


    

