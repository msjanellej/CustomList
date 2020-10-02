using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTests
{
    [TestClass]
    public class MinusOverload
    {
        [TestMethod]
        public void MinusOverload_INTSubtractZeroIndex_ZeroIndexRemovedfromBothLists()
        {
            //assign
            CustomList<int> testArrayOne = new CustomList<int>();
            CustomList<int> testArrayTwo = new CustomList<int>();
            CustomList<int> resultList = new CustomList<int>();
            string expected = "35";
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
        public void MinusOverload_subtractingTwoItemsFromList_BothMatchingIndexesRemoved()
        {
            //assign
            CustomList<int> testArrayOne = new CustomList<int>();
            CustomList<int> testArrayTwo = new CustomList<int>();
            CustomList<int> resultList = new CustomList<int>();
            string expected = "37";
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
        public void MinusOverload_SubtractNotAtSameIndex_MatchingItemsRemovedFromLists()
        {
            //assign
            CustomList<int> testArrayOne = new CustomList<int>();
            CustomList<int> testArrayTwo = new CustomList<int>();
            CustomList<int> resultList = new CustomList<int>();
            string expected = "35";
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
        public void MinusOverload_SubtractTwoIndexesCheckCount_NewListCountGoesDown()
        {
            //assign
            CustomList<int> testArrayOne = new CustomList<int>();
            CustomList<int> testArrayTwo = new CustomList<int>();
            CustomList<int> resultList = new CustomList<int>();
            int expected = 2;
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
        public void MinusOverload_NoMatchingValuesInArray_NewArrayHoldsAllValues()
        {
            //assign
            CustomList<int> testArrayOne = new CustomList<int>();
            CustomList<int> testArrayTwo = new CustomList<int>();
            CustomList<int> resultList = new CustomList<int>();
            string expected = "237651";
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
