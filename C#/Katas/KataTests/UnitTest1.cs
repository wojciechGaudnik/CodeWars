using Katas;

namespace Solution {
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SolutionTest
    {
        private static object[] Example_Test_Cases = new object[]
        {
            new object[] {"12:00", 0},
            new object[] {"12:00", 360},
            new object[] {"03:00", 90},
            new object[] {"06:00", 180},
            new object[] {"09:00", 270},
        };

        [Test, TestCaseSource(typeof(SolutionTest), "Example_Test_Cases")]
        public void Example_Test(string expected, double test)
        {
            Assert.AreEqual(expected, kyu6ClockyMcClockFace.WhatTimeIsIt(test));
        }
    }
}