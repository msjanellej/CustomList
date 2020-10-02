using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTests
{
    [TestClass]
    public class Sorting
    {
        [TestMethod]
        public void Sort_SortNumbersIntoOrder_NumbersInCorrectOrder()
        {
            //assign
            CustomList<int> arrayToBeSorted = new CustomList<int>() { 5, 10, 15, 4, 2, 6, 1 };
            CustomList<int> resultArray = new CustomList<int>();
            string actual;
            string expected = "124561015";
            
            //act
            resultArray = Sort(arrayToBeSorted);
            actual = resultArray.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
