using static Fabian.Week03.Arrays;
namespace FabianTest
{
    [TestClass]
    public class SortArrayTest
    {
        [TestMethod]
        public static void SortArrayTestMethod()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] sortedArray = { 5, 1, 9, 4, 2, 8, 6, 3, 10, 7 };
            sortedArray = BubbleSortASC(sortedArray);

            Assert.AreEqual(arr, sortedArray);
            
        }
    }
}
