using Katas;

namespace smile67Kata
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class smile67KataTest
    {
        [Test]
        public void smile67KataTest_withoutRandom1()
        {
            List<int> l = new List<int>(){2, 6, 17};
            Assert.AreEqual(l, new Basics05_TextSearch().searchText("aaabababa baabba aba", "aba", true));
        }
        [Test]
        public void smile67KataTest_withoutRandom3()
        {
            List<int> l = new List<int>();
            Assert.AreEqual(l, new Basics05_TextSearch().searchText("aaabababa baabba aba", "", false));

        }
        [Test]
        public void smile67KataTest_withoutRandom4()
        {
            List<int> l = new List<int>();
            Assert.AreEqual(l, new Basics05_TextSearch().searchText("", "aba", false));
        }
        [Test]
        public void smile67KataTest_withoutRandom2()
        {
            List<int> l = new List<int>() { 2, 4, 6, 17 };
            Assert.AreEqual(l, new Basics05_TextSearch().searchText("aaabababa baabba aba", "aba", false));
        }
    }
}