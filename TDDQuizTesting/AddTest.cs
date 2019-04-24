using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDQuiz;

namespace TDDQuizTesting
{
    [TestClass]
    public class AddTest
    {
        [TestMethod]
        public void EmptyStringTest()
        {
            Assert.AreEqual(0, Calculator.Add("",' '));
        }

        [TestMethod]
        public void StringToIntListTest()
        {
            int[] numbers = {1, 2, 3, 4};
            CollectionAssert.AreEqual(numbers, Calculator.StringToIntList("1,2,3,4", ','));
        }

        [TestMethod]
        public void AddNumbersTest()
        {
            Assert.AreEqual(7, Calculator.Add("1,2,3,1", ','));
        }

        [TestMethod]
        public void DelimitersTest()
        {
            int[] numbers = { 1, 2, 3, 4 };
            CollectionAssert.AreEqual(numbers, Calculator.StringToIntList("1;2;3;4", ';'));
        }

        [TestMethod]
        public void IgnoreNegativeTest()
        {
            Assert.AreEqual(6, Calculator.Add("1,2,3,-1", ','));
        }
    }
}
