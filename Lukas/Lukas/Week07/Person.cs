using System;
namespace Lukas.Week07
{
    public class Person
    {
        private string lastName;
        private string firstName;
        private DateTime dateOfBirth;
        private string gender;
        private List<Person> children = new();
        private string insuranceNumber;

        private static int personCreationCounter;

        public static int GetPersonCreationCounter()
        {
            return Person.personCreationCounter;
        }

        public Person(string lastName, string firstName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            personCreationCounter++;
        }

        public Person(string lastName, string firstName, DateTime dateOfBirth) : this(lastName, firstName)
        {
            this.dateOfBirth = dateOfBirth;
        }

        public Person(string lastName, string firstName, DateTime dateOfBirth, string genderInput) : this(lastName, firstName, dateOfBirth)
        {
            gender = genderInput;
        }

        public void addChild(Person p)
        {
            children.Add(p);
        }

        public void SetInsuranceNumber(string insuranceNumber)
        {
            this.insuranceNumber = insuranceNumber;
        }

        public void Shout2()
        {
            Console.WriteLine(lastName + ": HUAAAAAAAAAAAAAAAAA!!!111!!!");
        }

        public static void Shout()
        {
            Console.WriteLine("HUAAAAAAAAAAAAAAAAA!!!111!!!");
        }

        // Remaining implementation of Person class.
    }

}

