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
            Assert.AreEqual(0, count, "CountEven() doesn't work properly with empty list");
        }


        [TestMethod]
        public void CountEvenRandomList()
        {
            // arrange
            List<int> randomList = new List<int> { 1, 773, 6, 21, 47, 8, 342, 3, 12, 2, 43, 8, 45, 23, 132, 5, 613, 413, 12222 };

            // act
            int count = ListExercises.CountEven(randomList);

            // assert
            Assert.AreEqual(8, count, "CountEven() doesn't work with generic data list");
        }


        [TestMethod]
        public void CountEvenNegativeList()
        {
            // arrange
            List<int> negativeList = new List<int> { -32, -2, -23, -23, -16, -25, -5, -6, -69, -2, -1, -12, -4, -2, -234, -46, -3, -23, -42, -413, -34 };

            // act
            int count = ListExercises.CountEven(negativeList);

            // assert
            Assert.AreEqual(12, count, "CountEven() doesn't work with negative lists");
        }


        [TestMethod]
        public void CountEvenNullList()
        {
            // arrange
            List<int> nullList = null;

            // act
            int count = ListExercises.CountEven(nullList);

            // assert
            Assert.AreEqual(0, count, "CountEven() doesn't work on a null element");
        }
    }
}

