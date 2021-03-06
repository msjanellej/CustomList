﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTests
{
    [TestClass]
    public class String
    {
        [TestMethod]
        public void ToString_PutValueOfArrayIntoString_Expectedstring()
        {
            //arrange
            CustomList<int> testArray = new CustomList<int>();
            int firstNumber = 1;
            int secondNumber = 2;
            int thirdNumber = 3;
            string expected = "123";
            string actual;
            //act
            testArray.Add(firstNumber);
            testArray.Add(secondNumber);
            testArray.Add(thirdNumber);
            actual = testArray.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_PutStringsintoArray_StringList()
        {
            //arrange
            CustomList<string> testArray = new CustomList<string>();
            string firstWord = "My";
            string secondWord = "Name";
            string thirdWord = "Is";
            string fourthWord = "Janelle";
            string expected = "MyNameIsJanelle";
            string actual;
            //act
            testArray.Add(firstWord);
            testArray.Add(secondWord);
            testArray.Add(thirdWord);
            testArray.Add(fourthWord);
            actual = testArray.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_AddThreeItemsToString_DoesNotPrintEmptyIndex()
        {
            string firstWord = "Cats";
            string secondWord = "Are";
            string thirdWord = "Cool";
            string expected = "CatsAreCool";
            string actual;   
            CustomList<string> testArray = new CustomList<string>();
            //act
            testArray.Add(firstWord);
            testArray.Add(secondWord);
            testArray.Add(thirdWord);
            actual = testArray.ToString();
            //assert
            Assert.AreEqual(expected, actual);


        }


    }
}
