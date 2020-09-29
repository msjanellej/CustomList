using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;
using System.Collections.Generic;

namespace CustomListTests
{
    [TestClass]
    public class AddTests
    {
        [TestMethod]
        public void Add_AddFourNumbers_IntAddedCountFour()
        {
            //arrange
            int number = 6;
            int secondNumber = 5;
            int thirdNumber = 4;
            int fourthNumber = 2;
            CustomList<int> project = new CustomList<int>();
            int expected = 4;
            int actual;
            //act
            project.Add(number);
            project.Add(secondNumber);
            project.Add(thirdNumber);
            project.Add(fourthNumber);
            actual = project.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddTwoNumbers_IntAddedCountTwo()
        {
            //arrange
            int number = 6;
            int secondNumber = 5;
            CustomList<int> project = new CustomList<int>();
            int expected = 2;
            int actual;
            //act
            project.Add(number);
            project.Add(secondNumber);
            actual = project.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddFourNumbers_ThirdIndex2()
        {
            //arrange
            int number = 6;
            int secondNumber = 5;
            int thirdNumber = 4;
            int fourthNumber = 2;
            CustomList<int> project = new CustomList<int>();
            int expected = 2;
            int actual;
            //act
            project.Add(number);
            project.Add(secondNumber);
            project.Add(thirdNumber);
            project.Add(fourthNumber);
            actual = project[3];

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddCapacity_CapacityAt8()
        {
            CustomList<int> project = new CustomList<int>();
            //arrange
            int number = 1;
            int numberTwo = 2;
            int numberThree = 3;
            int numberFour = 4;
            int numberFive = 5;
            int expected = 8;
            int actual;
            //act
            project.Add(number);
            project.Add(numberTwo);
            project.Add(numberThree);
            project.Add(numberFour);
            project.Add(numberFive);
            actual = project.Capacity;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_Add5items_0indexremains()
        {
            CustomList<int> project = new CustomList<int>();
            //arrange
            int number = 1;
            int numberTwo = 2;
            int numberThree = 3;
            int numberFour = 4;
            int numberFive = 5;
            int expected = 1;
            int actual;
            //act
            project.Add(number);
            project.Add(numberTwo);
            project.Add(numberThree);
            project.Add(numberFour);
            project.Add(numberFive);
            actual = project[0];
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
