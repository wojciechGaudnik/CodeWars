using System;
using System.Collections.Generic;
using Katas;
using NUnit.Framework;

[TestFixture]
public class backwardsPrimeTests {
    [Test]
    public void Test13() {
        Assert.AreEqual("13 17 31 37 71 73 79 97", kyu6BackwardsReadPrimes.backwardsPrime(1, 100));
    }
    [Test]
    public void Test21() {
        Assert.AreEqual("9923 9931 9941 9967", kyu6BackwardsReadPrimes.backwardsPrime(9900, 10000));
    }

}