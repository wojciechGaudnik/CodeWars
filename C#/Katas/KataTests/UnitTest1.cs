using Katas;

namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class KataTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("20th", kyu6WhatCenturyIsIt.WhatCentury("1999"), "With input '1999' solution produced wrong output.");
            Assert.AreEqual("21st", kyu6WhatCenturyIsIt.WhatCentury("2011"), "With input '2011' solution produced wrong output.");
            Assert.AreEqual("22nd", kyu6WhatCenturyIsIt.WhatCentury("2154"), "With input '2154' solution produced wrong output.");
            Assert.AreEqual("23rd", kyu6WhatCenturyIsIt.WhatCentury("2259"), "With input '2259' solution produced wrong output.");
        }
    }
}