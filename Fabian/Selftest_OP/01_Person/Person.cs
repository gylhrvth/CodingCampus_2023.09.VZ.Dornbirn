
namespace Fabian.Selftest_OP._01_Person
{
    internal class Person
    {
        public enum Genders
        {
            female,
            male,
            divers
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public Genders Gender { get; set; }
        public Person(string name, int age, Genders gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"The person {Name} is {Age} years old and is {Gender}";
        }
    }
}
