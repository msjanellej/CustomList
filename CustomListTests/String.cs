using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTests
{
    [TestClass]
    public class String
    {
        [TestMethod]
        public void MakeString_PutValueOfZeroIndexIntoString_ExpectedOne()
        {
            //arrange
            CustomList<int> testArray = new CustomList<int>();
            int firstNumber = 1;
            int secondNumber = 2;
            int thirdNumber = 3;
            string expected = "1";
            string actual;
            //act
            testArray.Add(firstNumber);
            testArray.Add(secondNumber);
            testArray.Add(thirdNumber);
            actual = testArray.ToString(firstNumber);
            //assert
            Assert.AreEqual(expected, actual);
        }
        
      
    }
}
