using System;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;

namespace Riccardo.Week06;

internal class PersonBook
{
    public static void Start()
    {
        Person b1 = new Person(160, 23, "Stefan", 89);
        
       

        Console.WriteLine(b1);
        b1.Age = 120;

        b1.Age = 95;

        Console.WriteLine(b1);

        //Trainer Ausgabe

        CourseAndTrainer t1 = new CourseAndTrainer("Dr", 25092023, 500, 8000, "Paul");
        //  _Title, _Start, _CourseHours, _Price, _Trainer.Name, _Trainer.Age
        Console.WriteLine(t1);
       

     
    }
}
