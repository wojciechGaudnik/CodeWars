using Katas;

namespace Solution
{
    using NUnit.Framework;
    using System;
    using System.Linq;

    public class KataTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual("srot the inner ctonnet in dsnnieedcg oredr", kyu6SrotTheInnerCtonnetInDsnnieedcgOredr.SortTheInnerContent("sort the inner content in descending order"));
            Assert.AreEqual("wiat for me", kyu6SrotTheInnerCtonnetInDsnnieedcgOredr.SortTheInnerContent("wait for me"));
            Assert.AreEqual("tihs ktaa is esay", kyu6SrotTheInnerCtonnetInDsnnieedcgOredr.SortTheInnerContent("this kata is easy"));
        }
    }
}