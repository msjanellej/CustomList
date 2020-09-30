using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTests
{
    [TestClass]
    public class RemoveTests
    {
        [TestMethod]
        public void Remove_RemoveAtZeroIndex_EmptyZeroIndex()
        {
            //arrange
            CustomList<int> myArray = new CustomList<int>();
            int number = 1;
            int secondNumber = 2;
            int thirdNumber = 3;
            bool expected = true;;
            bool actual;
            //act
            myArray.Add(number);
            myArray.Add(secondNumber);
            myArray.Add(thirdNumber);
            actual = myArray.Remove(number);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveAtZeroIndex_CountGoesDown()
        {
            //arrange
            CustomList<int> myArray = new CustomList<int>();
            int number = 1;
            int secondNumber = 2;
            int thirdNumber = 3;
            int expected = 2; ;
            int actual;
            //act
            myArray.Add(number);
            myArray.Add(secondNumber);
            myArray.Add(thirdNumber);
            myArray.Remove(number);
            actual = myArray.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_ShiftItemsDown_ItemsShiftDownInIndex()
        {
            //arrange
            CustomList<int> myArray = new CustomList<int>();
            int number = 1;
            int secondNumber = 2;
            int thirdNumber = 3;
            int expected = 2; ;
            int actual;
            //act
            myArray.Add(number);
            myArray.Add(secondNumber);
            myArray.Add(thirdNumber);
            myArray.Remove(number);
            actual = myArray[0];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveItemAtSecondIndex_RemoveThirdNumber()
        {
            //arrange
            CustomList<int> myArray = new CustomList<int>();
            int number = 1;
            int secondNumber = 2;
            int thirdNumber = 3;
            int expected = 0; ;
            int actual;
            //act
            myArray.Add(number);
            myArray.Add(secondNumber);
            myArray.Add(thirdNumber);
            myArray.Remove(secondNumber);
            actual = myArray[2];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveSecondNumberTwice_NothingHappens()
        {
            //arrange
            CustomList<int> myArray = new CustomList<int>();
            int number = 1;
            int secondNumber = 2;
            int thirdNumber = 3;
            int expected = 2;
            int actual;
            //act
            myArray.Add(number);
            myArray.Add(secondNumber);
            myArray.Add(thirdNumber);
            myArray.Remove(secondNumber);
            myArray.Remove(secondNumber);
            actual = myArray.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveItemOnlyOnceWhenThereAreMultiple_OnlyRemoveFirst()
        {
            //arrange
            CustomList<int> myArray = new CustomList<int>();
            int number = 2;
            int secondNumber = 1;
            int thirdNumber = 2;
            int expected = 2;
            int actual;
            //act
            myArray.Add(number);
            myArray.Add(secondNumber);
            myArray.Add(thirdNumber);
            myArray.Remove(secondNumber);
         
            actual = myArray[1];
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
