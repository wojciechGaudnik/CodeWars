namespace Katas {
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void ExampleTest()
        {
            FileMaster FM = new FileMaster("/Users/person1/Pictures/house.png");
            Assert.AreEqual("png",FM.extension() );
            Assert.AreEqual("house", FM.filename());
            Assert.AreEqual("/Users/person1/Pictures/", FM.dirpath());
        }
    }
}