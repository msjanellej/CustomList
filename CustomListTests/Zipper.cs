using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTests
{
    [TestClass]
    public class Zipper
    {
        [TestMethod]
        public void Zipper_ZipThreeNumbers_NewListShouldHaveAllItems()
        {
            //arrange
            CustomList<int> testArrayOne = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> testArrayTwo = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> resultArray = new CustomList<int>();
            string expected = "123456";
            string actual;
            //act
            resultArray = Zip(testArrayOne, testArrayTwo);
            actual = resultArray.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zipper_ZipTwoArraysofDifferentSizes_NewListShouldZipItemsAndAddExtraItemsToEnd()
        {
            //arrange
            CustomList<int> testArrayOne = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> testArrayTwo = new CustomList<int>() {2,4,6,8,10};
            CustomList<int> resultArray = new CustomList<int>();
            string expected = "123456810";
            string actual;
            //act
            resultArray = Zip(testArrayOne, testArrayTwo);
            actual = resultArray.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zipper_ZipTwoListsOneListEmpty_JustFirstListDisplayed()
        {
            //arrange
            CustomList<int> testArrayOne = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> testArrayTwo = new CustomList<int>();
            CustomList<int> resultArray = new CustomList<int>();
            string expected = "135";
            string actual;
            //act
            resultArray = Zip(testArrayOne, testArrayTwo);
            actual = resultArray.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zipper_ZipThreeNumbers_CountShouldGoUpOnResultList()
        {
            //arrange
            CustomList<int> testArrayOne = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> testArrayTwo = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> resultArray = new CustomList<int>();
            int expected = 6;
            int actual;
            //act
            resultArray = Zip(testArrayOne, testArrayTwo);
            actual = resultArray.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zipper_ZipTwoEmptyLists_NewListCountShouldBeZero()
        {
            //arrange
            CustomList<int> testArrayOne = new CustomList<int>();
            CustomList<int> testArrayTwo = new CustomList<int>();
            CustomList<int> resultArray = new CustomList<int>();
            string expected = null;
            string actual;
            //act
            resultArray = Zip(testArrayOne, testArrayTwo);
            actual = resultArray.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
