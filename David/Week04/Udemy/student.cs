using System;
using David.Week04.Udemy;
namespace David.Week04.Udemy
{
	public class Student
	{
		public int Id { get; private set; }
		public string Name { get; private set; }

		public float GradePointAverage { get; private set; }

		public Student(int id, string name, float greadePointAverage)
		{
			Id = id;
			Name = name;
			GradePointAverage = greadePointAverage;
		}
	}
}

