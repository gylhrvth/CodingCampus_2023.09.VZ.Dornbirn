using System;
using David.Week04.Udemy;
namespace David.Week04.Udemy
{
	public class studentMain
	{

		public static void Start()
		{
			List<Student> students = new List<Student>();

			students.Add(new Student(1, "David", 2.2f));
            students.Add(new Student(2, "Camilo", 1.5f));
            students.Add(new Student(3, "José", 1.0f));

			float totalGradePoints = 0;

			foreach (Student student in students)
			{
				totalGradePoints += student.GradePointAverage;
			}

			float averageGradePoint = totalGradePoints / students.Count;
			Console.WriteLine("Durchscnittsnote ist: " + averageGradePoint);

        }
    }


}

