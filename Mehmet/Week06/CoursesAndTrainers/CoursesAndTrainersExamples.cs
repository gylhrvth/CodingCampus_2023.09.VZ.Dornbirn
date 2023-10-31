using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week06.CoursesAndTrainers
{
    


    internal class CoursesAndTrainersExamples
    {

        public static void Start()
        {
            CoursesAndTrainers cat1 = new CoursesAndTrainers("Coding", DateTime.Today, 69, 31,new Person(188, 21, "Hassan", 80));



            Console.WriteLine(cat1);
        }


        


    }
}
