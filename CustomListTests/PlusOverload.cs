using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTests
{
    [TestClass]
    public class PlusOverload
    {
        [TestMethod]
        public void PlusOverload_AddTwoListsTogether_ListsConcatinate()
        {
            //arrange
            CustomList<int> testArrayOne = new CustomList<int>();
            CustomList<int> testArrayTwo = new CustomList<int>();
            int firstNumber = 0;
            int secondNumber = 1;
            int thirdNumber = 2;
            int fourthNumber = 3;
            int fifthNumber = 4;
            int sixthNumber = 5;
            int expected = 012345;
            CustomList<int> actualList = new CustomList<int>();
            string actual;
            //act
            testArrayOne.Add(firstNumber);
            testArrayOne.Add(secondNumber);
            testArrayOne.Add(thirdNumber);
            testArrayTwo.Add(fourthNumber);
            testArrayTwo.Add(fifthNumber);
            testArrayTwo.Add(sixthNumber);
            actualList = testArrayOne + testArrayTwo;
            actual = actualList.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PlusOverload_AddTwoListsTogetherStrings_Concatinate()
        {
            //arrange
            CustomList<string> testArrayOne = new CustomList<string>();
            CustomList<string> testArrayTwo = new CustomList<string>();
            string firstWord = "One";
            string secondWord = "Piece";
            string thirdWord = "Is";
            string fourthWord = "The";
            string fifthWord = "Best";
            string sixthWord = "Anime";
            string expected = "OnePeiceIsTheBestAnime";
            string actual;
            CustomList<string> actualList = new CustomList<string>();
            //act
            testArrayOne.Add(firstWord);
            testArrayOne.Add(secondWord);
            testArrayOne.Add(thirdWord);
            testArrayTwo.Add(fourthWord);
            testArrayTwo.Add(fifthWord);
            testArrayTwo.Add(sixthWord);
            actualList = testArrayOne + testArrayTwo;
            actual = actualList.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PlusOverload_AddTwoArraysTogetherOneListEmpty_NewArrayShowsOnlyItemsInFirstArray()
        {
            //arrange
            CustomList<string> testArrayOne = new CustomList<string>();
            CustomList<string> testArrayTwo = new CustomList<string>();
            string firstWord = "One";
            string secondWord = "Piece";
            string thirdWord = "Is";
            string fourthWord = "Best";
            string expected = "OnePeiceIsBest";
            CustomList<string> actualList = new CustomList<string>();
            string actual;
            //act
            testArrayOne.Add(firstWord);
            testArrayOne.Add(secondWord);
            testArrayOne.Add(thirdWord);
            testArrayOne.Add(fourthWord);

            actualList = testArrayOne + testArrayTwo;
            actual = actualList.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PlusOverload_BothArraysAreEmpty_EmptyResultArray()
        {
            //arrange
            CustomList<string> testArrayOne = new CustomList<string>();
            CustomList<string> testArrayTwo = new CustomList<string>();
            string expected = "";
            CustomList<string> actualList = new CustomList<string>();
            string actual;
            //act
            actualList = testArrayOne + testArrayTwo;
            actual = actualList.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PlusOverload_AddTwoListsTogetherStringsCheckCount_CountReflectsBothStrings()
        {
            //arrange
            CustomList<string> testArrayOne = new CustomList<string>();
            CustomList<string> testArrayTwo = new CustomList<string>();
            string firstWord = "One";
            string secondWord = "Piece";
            string thirdWord = "Is";
            string fourthWord = "The";
            string fifthWord = "Best";
            string sixthWord = "Anime";
            int expected = 6;
            int actual;
            CustomList<string> actualList = new CustomList<string>();
            //act
            testArrayOne.Add(firstWord);
            testArrayOne.Add(secondWord);
            testArrayOne.Add(thirdWord);
            testArrayTwo.Add(fourthWord);
            testArrayTwo.Add(fifthWord);
            testArrayTwo.Add(sixthWord);
            actualList = testArrayOne + testArrayTwo;
            actual = actualList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
