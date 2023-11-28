using Fabian.Week06._01Person;
namespace FabianTest
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void Person1Test()
        {
            string name = "Fabian";
            int age = 17;
            int height = 187;
            double weight = 75;

            Person p1 = new Person(name, age, height, weight);

            Assert.AreEqual(name, p1.Name);
            Assert.AreEqual(age, p1.Age);
            Assert.AreEqual(height, p1.Height);
            Assert.AreEqual(weight, p1.Weight, 0.001);
        }
    }
    
}