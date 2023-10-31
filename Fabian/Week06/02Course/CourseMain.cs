using Fabian.Week06._01Person;
namespace Fabian.Week06._02Course
{
    public class CourseMain
    {
        public static void Start()
        {
            Course c1 = new("Programming Course", new DateTime(2023, 9, 30), 300, 3000, new Person("Hassan", 69, 188, 200));
            Console.WriteLine(c1);
        }
    }
}
