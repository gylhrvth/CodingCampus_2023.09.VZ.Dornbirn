using Fabian.Week06._03Person;
using static Fabian.Week06._03Person.Person2Start;
namespace FabianTest
{
    [TestClass]
    public class Person2Test
    {
        [TestMethod]
        public void Person2NameTest()
        {
            Person2 p1 = new Person2("Fabian", 17, 187, 75);
            Person2 p2 = new Person2("Hassan", 19, 177, 60);
            Person2 p3 = new Person2("Lukas", 22, 190, 50);
            Person2 p4 = new Person2("Gyula", 40, 200, 100);
            Person2 p5 = new Person2("Sandro", 25, 163, 53);

            List<Person2> persons = new List<Person2> { p1, p2, p3, p4, p5 };
            persons = SortPersons(persons, Data.NAME);

            List<Person2> namesExpected = new List<Person2> { p1, p4, p2, p3, p5 };

            CollectionAssert.AreEqual(namesExpected, persons);
        }
    }
}
