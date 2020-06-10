using Katas;

namespace Solution
{
    using NUnit.Framework;
    using System;  
    using System.Linq;
  
    public class kyu6ReducingByRulesToGetTheResultTests
    {
        [Test]
        public void ExampleTests()
        {
            Func<double, double, double>[] rules = new Func<double, double, double>[] { 
                (a, b) => a + b,
                (a, b) => a - b
            };

            Assert.AreEqual(5.0, kyu6ReducingByRulesToGetTheResult.ReduceByRules(new[] { 2.0, 2.0, 3.0, 4.0 }, rules));
      
            rules = new Func<double, double, double>[] { (a, b) => a + b };

            Assert.AreEqual(6.0, kyu6ReducingByRulesToGetTheResult.ReduceByRules(new[] { 2.0, 2.0, 2.0 }, rules));
            Assert.AreEqual(8.0, kyu6ReducingByRulesToGetTheResult.ReduceByRules(new[] { 2.0, 2.0, 2.0, 2.0 }, rules));
            Assert.AreEqual(10.0, kyu6ReducingByRulesToGetTheResult.ReduceByRules(new[] { 2.0, 2.0, 2.0, 2.0, 2.0 }, rules));
            Assert.AreEqual(12.0, kyu6ReducingByRulesToGetTheResult.ReduceByRules(new[] { 2.0, 2.0, 2.0, 2.0, 2.0, 2.0 }, rules));

            rules = new Func<double, double, double>[] { (a, b) => a + b, (a, b) => a - b, (a, b) => a * b };

            Assert.AreEqual(2.0, kyu6ReducingByRulesToGetTheResult.ReduceByRules(new [] { 2.0, 2.0, 2.0 }, rules));
            Assert.AreEqual(4.0, kyu6ReducingByRulesToGetTheResult.ReduceByRules(new[] { 2.0, 2.0, 2.0, 2.0 }, rules));
            Assert.AreEqual(6.0, kyu6ReducingByRulesToGetTheResult.ReduceByRules(new[] { 2.0, 2.0, 2.0, 2.0, 2.0 }, rules));
            Assert.AreEqual(4.0, kyu6ReducingByRulesToGetTheResult.ReduceByRules(new[] { 2.0, 2.0, 2.0, 2.0, 2.0, 2.0 }, rules));

            rules = new Func<double, double, double>[] { (a, b) => Math.Min(a,b), (a, b) => Math.Max(a,b) };

            Assert.AreEqual(3.3, kyu6ReducingByRulesToGetTheResult.ReduceByRules(new [] { 1.3, 2.0, 3.3 }, rules));
            Assert.AreEqual(2.2, kyu6ReducingByRulesToGetTheResult.ReduceByRules(new[] { 4.1, 2.2, 2.1, 2.5 }, rules));
            Assert.AreEqual(8.0, kyu6ReducingByRulesToGetTheResult.ReduceByRules(new[] { 8.0, 8.1, 4.1, 12.0, 2.0 }, rules));
            Assert.AreEqual(2.4, kyu6ReducingByRulesToGetTheResult.ReduceByRules(new[] { 2.9, 2.8, 2.7, 2.6, 2.5, 2.4 }, rules));
        }
    }
}