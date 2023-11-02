using System;

namespace Jovo.Week06
{
    public class PersonMain
    {
        public static void Start()
        {
            Person p1 = new Person("Memoooo", 24 , 180, 82);
            Person p2 = new Person("Hassan", 21, 190, 80);

            Console.WriteLine(p1.Name);
            p1.Name = "Gyula";
            p1.Age = 1;
            p2.Height = 188;
            p2.Weight = 132;

            Console.WriteLine(p1);

        }

    }
}
