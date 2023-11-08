using System;
using Gyula.Week06.CourseList;
namespace GyulaTest.Week06
{
	[TestClass]
	public class PersonUnitTest
	{
		[TestMethod]
		public void CreatePersonTest()
		{
            // arrange
            Person p = new Person("Gyula", 44, 172, 78);

            // act
            string stringValue = p.ToString();

            // assert
            Assert.AreEqual("Gyula", stringValue);
        }
	}
}

