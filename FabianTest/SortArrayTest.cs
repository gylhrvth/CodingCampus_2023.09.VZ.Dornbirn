using static Fabian.Week03.Arrays;
namespace FabianTest
{
    [TestClass]
    public class SortArrayTest
    {
        [TestMethod]
        public void BubbleSortTest()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] sortedArray = { 5, 1, 9, 4, 2, 8, 6, 3, 10, 7 };

           
            sortedArray = BubbleSortASC(sortedArray);  
           
            CollectionAssert.AreEqual(arr, sortedArray);           
        }

        [TestMethod]
        public void SelectionSortTest()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] sortedArray = { 5, 1, 9, 4, 2, 8, 6, 3, 10, 7 };

            sortedArray = SelectionSort(sortedArray);

            CollectionAssert.AreEqual(arr, sortedArray);
        }

        [TestMethod]
        public void InsertionSortTest()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] sortedArray = { 5, 1, 9, 4, 2, 8, 6, 3, 10, 7 };

            sortedArray = InsertionSort(sortedArray);

            CollectionAssert.AreEqual(arr, sortedArray);
        }
    }
}
