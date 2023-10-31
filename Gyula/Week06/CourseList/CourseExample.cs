using System;
namespace Gyula.Week06.CourseList
{
	public class CourseExample
	{
		public static void Start()
		{
			Person p = new Person("Artur", 21, 178, 72);
			Person gyula = new Person("Gyula", 44, 172, 78);

			Course softwareDeveloper = new Course("Software Developer", new DateTime(2023, 9, 26), 500);
			softwareDeveloper.Trainer = gyula;
			Console.WriteLine(softwareDeveloper);

			softwareDeveloper.Trainer = null;
            Console.WriteLine(softwareDeveloper);

			softwareDeveloper.Trainer = p;
			Console.WriteLine(softwareDeveloper);
        }
	}
}

