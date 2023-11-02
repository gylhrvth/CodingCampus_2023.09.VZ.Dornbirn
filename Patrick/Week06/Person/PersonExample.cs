using System;

namespace Patrick
{
    public class PersonExample
    {
        public static void Start()
        {
            Person b1 = new Person(1.65, 26, "Sebastian", 83.4);
            Person b2 = new Person(1.95, 35, "David", 103);

            Console.WriteLine(b1);
            Console.WriteLine();
            Console.WriteLine(b2);

        }

    }
}
