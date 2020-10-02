using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTests
{
    [TestClass]
    public class MinusOverload
    {
        [TestMethod]
        public void MinusOverload_INTSubtractZeroIndex_ZeroIndexRemoved()
        {
            //assign
            CustomList<int> testArrayOne = new CustomList<int>();
            CustomList<int> testArrayTwo = new CustomList<int>();
            CustomList<int> resultList = new CustomList<int>();
            string expected = "3";
            string actual;
            //act
            testArrayOne.Add(1);
            testArrayOne.Add(3);
            testArrayTwo.Add(1);
            testArrayTwo.Add(5);
            resultList = testArrayOne - testArrayTwo;
            actual = resultList.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MinusOverload_subtractingTwoItemsFromList_MatchingIndexRemovedFromFirstList()
        {
            //assign
            CustomList<int> testArrayOne = new CustomList<int>();
            CustomList<int> testArrayTwo = new CustomList<int>();
            CustomList<int> resultList = new CustomList<int>();
            string expected = "3";
            string actual;
            //act
            testArrayOne.Add(1);
            testArrayOne.Add(3);
            testArrayOne.Add(5);
            testArrayTwo.Add(1);
            testArrayTwo.Add(7);
            testArrayTwo.Add(5);
            resultList = testArrayOne - testArrayTwo;
            actual = resultList.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MinusOverload_SubtractNotAtSameIndex_MatchingItemsRemovedFromFirstList()
        {
            //assign
            CustomList<int> testArrayOne = new CustomList<int>();
            CustomList<int> testArrayTwo = new CustomList<int>();
            CustomList<int> resultList = new CustomList<int>();
            string expected = "3";
            string actual;
            //act
            testArrayOne.Add(1);
            testArrayOne.Add(3);
            testArrayOne.Add(7);
            testArrayTwo.Add(7);
            testArrayTwo.Add(5);
            testArrayTwo.Add(1);
            resultList = testArrayOne - testArrayTwo;
            actual = resultList.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MinusOverload_SubtractTwoIndexesCheckCount_CountGoesDown()
        {
            //assign
            CustomList<int> testArrayOne = new CustomList<int>();
            CustomList<int> testArrayTwo = new CustomList<int>();
            CustomList<int> resultList = new CustomList<int>();
            int expected = 1;
            int actual;
            //act
            testArrayOne.Add(1);
            testArrayOne.Add(3);
            testArrayOne.Add(7);
            testArrayTwo.Add(7);
            testArrayTwo.Add(5);
            testArrayTwo.Add(1);
            resultList = testArrayOne - testArrayTwo;
            actual = resultList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MinusOverload_NoMatchingValuesInArray_ResultHasAllValues()
        {
            //assign
            CustomList<int> testArrayOne = new CustomList<int>();
            CustomList<int> testArrayTwo = new CustomList<int>();
            CustomList<int> resultList = new CustomList<int>();
            string expected = "237";
            string actual;
            //act
            testArrayOne.Add(2);
            testArrayOne.Add(3);
            testArrayOne.Add(7);
            testArrayTwo.Add(6);
            testArrayTwo.Add(5);
            testArrayTwo.Add(1);
            resultList = testArrayOne - testArrayTwo;
            actual = resultList.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
