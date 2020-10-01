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
            CustomList<int> actual = new CustomList<int>();
            //act
            testArrayOne.Add(firstNumber);
            testArrayOne.Add(secondNumber);
            testArrayOne.Add(thirdNumber);
            testArrayTwo.Add(fourthNumber);
            testArrayTwo.Add(fifthNumber);
            testArrayTwo.Add(sixthNumber);
            actual = testArrayOne + testArrayTwo;

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
            CustomList<string> actual = new CustomList<string>();
            //act
            testArrayOne.Add(firstWord);
            testArrayOne.Add(secondWord);
            testArrayOne.Add(thirdWord);
            testArrayTwo.Add(fourthWord);
            testArrayTwo.Add(fifthWord);
            testArrayTwo.Add(sixthWord);
            actual = testArrayOne + testArrayTwo;

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
