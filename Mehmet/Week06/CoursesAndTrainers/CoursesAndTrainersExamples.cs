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
            CoursesAndTrainers cat1 = new CoursesAndTrainers("Coding", new DateTime(1990, 1, 15), 69, 31,new Person(188, 21, "Hassan", 80));

            Person trainer2 = new Person(177, 76, "Otto", 45);
            cat1.Trainer = trainer2;

            Console.WriteLine(cat1);
        }


        


    }
}
