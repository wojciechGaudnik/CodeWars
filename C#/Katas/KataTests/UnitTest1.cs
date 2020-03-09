using Katas;

namespace Solution
{
    using NUnit.Framework;

    [TestFixture]
    public class Tests
    {
        [TestCase("zodiac", 26)]
        [TestCase("chruschtschov", 80)]
        [TestCase("khrushchev", 38)]
        [TestCase("strength", 57)]
        [TestCase("catchphrase", 73)]
        [TestCase("twelfthstreet", 103)]
        [TestCase("mischtschenkoana", 80)]
        public void BasicTests(string input, int expected)
        {
            Assert.That(kyu6ConstantValue.Solve(input), Is.EqualTo(expected));
        }
    }
}