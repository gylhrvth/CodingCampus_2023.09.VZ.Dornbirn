using System;
using Michael.Week06;

namespace MichaelTest.Week06
{
	[TestClass]
	public class ListExercisesUnitTest
	{
		[TestMethod]
		public void CountEvenEmptyList()
		{
            // arrange
            List<int> emptyList = new List<int>();

            // act
            int count = ListExercises.CountEven(emptyList);

            // assert
            Assert.AreEqual(0, count, "CountEven doesn't work properly with empty list");
        }
    }
}

