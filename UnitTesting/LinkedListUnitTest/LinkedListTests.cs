using System;
using CustomLinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedListUnitTest
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void Test_DynamicListCount_ShouldBeZero()
        {
            DynamicList<int> testList = new DynamicList<int>();
           
            Assert.AreEqual(0, testList.Count, "Count is not zero when initialize DynamicList!");
        }

        [TestMethod]
        public void Test_DynamicListAdd_ShouldHasFifteenItem()
        {
            DynamicList<int> testList = new DynamicList<int>();
            int count = 15;

            for (int number = 0; number < count; number++)
            {
                testList.Add(number);
            }

            Assert.AreEqual(count, testList.Count, "Count is not fifteen when add a fifteen items to DynamicList!");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_DynamicListGetIndex_ShouldThrowException()
        {
            DynamicList<int> testList = new DynamicList<int>();
            int testNumber = 15;

            testList.Add(testNumber);
            int actual = testList[5];
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_DynamicListSetIndex_ShouldThrowException()
        {
            DynamicList<int> testList = new DynamicList<int>();
            int setterTest = 15;

            testList[3] = setterTest;
        }

        [TestMethod]
        public void Test_DynamicListGetIndex_ShouldReturnCorrectNumber()
        {
            DynamicList<int> testList = new DynamicList<int>();
            int testNumber = 15;

            testList.Add(testNumber);
            int actual = testList[0];

            Assert.AreEqual(15, actual, "Number is not the same!");
        }

        [TestMethod]
        public void Test_DynamicListSetIndex_ShouldSetCorrectNumber()
        {
            DynamicList<int> testList = new DynamicList<int>();
            int testNumber = 15;
            int numberForSet = 2;

            testList.Add(testNumber);
            testList[0] = numberForSet;
            int actual = testList[0];

            Assert.AreEqual(2, actual, "Number is not the same!");
        }

        [TestMethod]
        public void Test_DynamicListAdd_ShouldHasOneItem()
        {
            DynamicList<int> testList = new DynamicList<int>();
            int testNumber = 15;

            testList.Add(testNumber);
            int actual = testList[0];

            Assert.AreEqual(15, actual, "Added number is differnet");
            Assert.AreEqual(1, testList.Count, "Count is not one when add a item to DynamicList!");
        }

        [TestMethod]
        public void Test_DynamicListRemoveAt_ShouldRemoveAtGivenIndex()
        {
            DynamicList<int> testList = new DynamicList<int>();
            int count = 15;

            for (int number = 0; number < count; number++)
            {
                testList.Add(number*10);
            }
            int actualIndext = testList.RemoveAt(5);

            Assert.AreEqual(50, actualIndext, "Removed index is not the same number!");
        }

        [TestMethod]
        public void Test_DynamicListRemoveItem_ShouldRemoveGivenItem()
        {
            DynamicList<string> testList = new DynamicList<string>();
            string item = "dynamic";

            testList.Add(item);
            testList.Remove(item);

            Assert.AreEqual(0, testList.Count, "Count is not zero after removing item!");
        }

        [TestMethod]
        public void Test_DynamicListRemoveItem_ShouldReturnMinusOne()
        {
            DynamicList<string> testList = new DynamicList<string>();
            string item = "dynamic";

            testList.Add(item);
            int actual = testList.Remove("list");

            Assert.AreEqual(-1, actual, "Did not return minus one for missing item in the list!");
        }

        [TestMethod]
        public void Test_DynamicListIndexOf_ShouldReturnMinusOne()
        {
            DynamicList<string> testList = new DynamicList<string>();
            string item = "dynamic";

            testList.Add(item);
            int actual = testList.IndexOf("list");

            Assert.AreEqual(-1, actual, "Did not return minus one for missing item in the list!");
        }


        [TestMethod]
        public void Test_DynamicListIndexOf_ShouldReturnIndex()
        {
            DynamicList<string> testList = new DynamicList<string>();
            string item = "dynamic";

            testList.Add(item);
            int actual = testList.IndexOf(item);

            Assert.AreEqual(0, actual, "Did not return zero for finding the item in the list!");
        }

        [TestMethod]
        public void Test_DynamicListContain_ShouldReturnTrue()
        {
            DynamicList<string> testList = new DynamicList<string>();
            string item = "dynamic";

            testList.Add(item);
            bool actual = testList.Contains(item);

            Assert.AreEqual(true, actual, "Did not return true when find the item in the list!");
        }

        [TestMethod]
        public void Test_DynamicListContain_ShouldReturnFalse()
        {
            DynamicList<string> testList = new DynamicList<string>();
            string item = "dynamic";

            testList.Add(item);
            bool actual = testList.Contains("list");

            Assert.AreEqual(false, actual, "Did not return false when not find the item in the list!");
        }
    }
}
