﻿using System;
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
            Assert.Equals(0, Calculator.Add(""));
        }
    }
}
