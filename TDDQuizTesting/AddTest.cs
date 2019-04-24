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
            Assert.AreEqual(0, Calculator.Add(""));
        }

        [TestMethod]
        public void StringToIntListTest()
        {
            int[] numbers = {1, 2, 3, 4};
            CollectionAssert.AreEqual(numbers, Calculator.StringToIntList("1,2,3,4"));
        }
    }
}
