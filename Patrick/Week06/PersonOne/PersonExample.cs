using System;

namespace Patrick.Week06.PersonOne 
{
    public class PersonExample
    {
        public static void Start()
        {
            Person b1 = new Person("Sebastian", 26, 1.65, 83.4);
            Person b2 = new Person("David", 35, 1.95, 103);

            Console.WriteLine(b1);
            Console.WriteLine();
            Console.WriteLine(b2);

        }

    }
}
