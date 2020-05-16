using NUnit.Framework;
using System;
using Katas;

namespace Solution
{
    [TestFixture]
    public class kyu6MostFrequentWeekDaysTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new [] { "Friday", "Saturday" }, kyu6MostFrequentWeekDays.MostFrequentDays(2016));
            Assert.AreEqual(new [] { "Monday" }, kyu6MostFrequentWeekDays.MostFrequentDays(1770));
            Assert.AreEqual(new [] { "Monday" }, kyu6MostFrequentWeekDays.MostFrequentDays(2001));
            Assert.AreEqual(new [] { "Monday", "Tuesday" }, kyu6MostFrequentWeekDays.MostFrequentDays(1968));
            Assert.AreEqual(new [] { "Saturday" }, kyu6MostFrequentWeekDays.MostFrequentDays(1785));
            Assert.AreEqual(new [] { "Saturday" }, kyu6MostFrequentWeekDays.MostFrequentDays(1910));
            Assert.AreEqual(new [] { "Saturday" }, kyu6MostFrequentWeekDays.MostFrequentDays(2135));
            Assert.AreEqual(new [] { "Sunday" }, kyu6MostFrequentWeekDays.MostFrequentDays(3043));
            Assert.AreEqual(new [] { "Sunday" }, kyu6MostFrequentWeekDays.MostFrequentDays(3150));
            Assert.AreEqual(new [] { "Thursday" }, kyu6MostFrequentWeekDays.MostFrequentDays(3361));
            Assert.AreEqual(new [] { "Tuesday" }, kyu6MostFrequentWeekDays.MostFrequentDays(1901));
            Assert.AreEqual(new [] { "Tuesday" }, kyu6MostFrequentWeekDays.MostFrequentDays(3230));
            Assert.AreEqual(new [] { "Wednesday" }, kyu6MostFrequentWeekDays.MostFrequentDays(1794));
            Assert.AreEqual(new [] { "Wednesday" }, kyu6MostFrequentWeekDays.MostFrequentDays(1986));

        }
    }
}