using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week06.SomeTrys
{
    internal class StudentenMain
    {
        public static void Start()
        {
            List<Student> students = new List<Student>();

            students.Add(new Student(1, "Jannick", 2.3f));
            students.Add(new Student(2, "Peter", 8.8f));
            students.Add(new Student(3, "Maria", 2.1f));

            float totalGradePoints = 0;
            
            foreach (Student student in students)
            {
                totalGradePoints += student._GradePointAverage;

            }

            float averageGradePoint = totalGradePoints / students.Count;
            Console.WriteLine("der durchschnittliche NC ist:" + averageGradePoint);
        }
    }
}
