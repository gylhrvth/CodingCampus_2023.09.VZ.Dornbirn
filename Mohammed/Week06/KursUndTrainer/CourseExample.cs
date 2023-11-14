using System;
namespace Mohammed.Week06.KursUndTrainer;

public class CourseExample
{
	public static void Start()
	{
		Person p = new Person("Mohammed", 21, 180, 83);
		Person Gyula = new Person("Gyula", 33, 170, 78);

		Course softwareDeveloper = new Course("softwareDeveloper", new DateTime(2023, 09, 26), 500);
		softwareDeveloper.Trainer = Gyula;
		Console.WriteLine(softwareDeveloper);

		softwareDeveloper.Trainer = null;
		Console.WriteLine(softwareDeveloper);

		softwareDeveloper.Trainer = p;
		Console.WriteLine(softwareDeveloper);
	}
}

