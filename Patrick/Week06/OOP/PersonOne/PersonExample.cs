using System;

namespace Patrick.Week06.OOP.PersonOne
{
    public class PersonExample
    {
        public static void Start()
        {
            Person b1 = new Person("Sebastian", 26, 1.65f, 83.4f);
            Person b2 = new Person("David", 35, 1.95f, 103f);

            Console.WriteLine(b1);
            Console.WriteLine();
            Console.WriteLine(b2);

        }

    }
}
