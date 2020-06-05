using NUnit.Framework;
using System;
using System.Numerics;
using Katas;

public class SolutionTest
{
    [Test]
    public void SampleTests()
    {
        Assert.AreEqual(new BigInteger(7), kyu4CountOnesInASegment.CountOnes(5, 7));
        Assert.AreEqual(new BigInteger(51), kyu4CountOnesInASegment.CountOnes(12, 29));
        Assert.AreEqual(new BigInteger(205274), kyu4CountOnesInASegment.CountOnes(1200, 29000));
        Assert.AreEqual(new BigInteger(916107), kyu4CountOnesInASegment.CountOnes(193303, 289384));
        Assert.AreEqual(new BigInteger(1590906), kyu4CountOnesInASegment.CountOnes(121234, 291324));
        Assert.AreEqual(new BigInteger(18673286), kyu4CountOnesInASegment.CountOnes(1212341, 2913249));
        Assert.AreEqual(new BigInteger(4056185136), kyu4CountOnesInASegment.CountOnes(12123, 291324912));



        Assert.AreEqual(new BigInteger(1432400583258076), kyu4CountOnesInASegment.CountOnes(93960293923410, 153413882626292));
    }
}

// // 0 <-> 1 <-> 1 <-> 1
// // 1 <-> 2 <-> 10 <-> 2
// // 2 <-> 4 <-> 100 <-> 5
// // 3 <-> 8 <-> 1000 <-> 13
// // 4 <-> 16 <-> 10000 <-> 33
// // 5 <-> 32 <-> 100000 <-> 81
// // 6 <-> 64 <-> 1000000 <-> 193
// // 7 <-> 128 <-> 10000000 <-> 449
// // 8 <-> 256 <-> 100000000 <-> 1025
// // 9 <-> 512 <-> 1000000000 <-> 2305
// // 10 <-> 1024 <-> 10000000000 <-> 5121
// // 11 <-> 2048 <-> 100000000000 <-> 11265
// // 12 <-> 4096 <-> 1000000000000 <-> 24577
// // 13 <-> 8192 <-> 10000000000000 <-> 53249
// // 14 <-> 16384 <-> 100000000000000 <-> 114689
// // 15 <-> 32768 <-> 1000000000000000 <-> 245761
// // 16 <-> 65536 <-> 10000000000000000 <-> 524289
// // 17 <-> 131072 <-> 100000000000000000 <-> 1114113
// // 18 <-> 262144 <-> 1000000000000000000 <-> 2359297
// // 19 <-> 524288 <-> 10000000000000000000 <-> 4980737
// // 20 <-> 1048576 <-> 100000000000000000000 <-> 10485761
// // 21 <-> 2097152 <-> 1000000000000000000000 <-> 22020097
// // 22 <-> 4194304 <-> 10000000000000000000000 <-> 46137345
// // 23 <-> 8388608 <-> 100000000000000000000000 <-> 96468993
// // 24 <-> 16777216 <-> 1000000000000000000000000 <-> 201326593
// // 25 <-> 33554432 <-> 10000000000000000000000000 <-> 419430401
// // 26 <-> 67108864 <-> 100000000000000000000000000 <-> 872415233
// // 27 <-> 134217728 <-> 1000000000000000000000000000 <-> 1811939329
// // 28 <-> 268435456 <-> 10000000000000000000000000000 <-> 3758096385
// // 29 <-> 536870912 <-> 100000000000000000000000000000 <-> 7784628225
// // 30 <-> 1073741824 <-> 1000000000000000000000000000000 <-> 16106127361
//
//
// // 5
// // 5
// // 6
// // 1
// // 2
// // 2
// // 3
// // 2
// // 3
// // 3
// // 4
// // 2
// // 3
// // 3
// // 4
// // 3
// // 4
// // 4
// // 5
// // 2
// // 3
// // 3
// // 4
// // 3
// // 4
// // 4
// // 5
// // 3
// // 4
// // 4
// // 5
// // 4
//



namespace Katas
{
    using NUnit.Framework;
    using System;
    [TestFixture]
    public class DayTest
    {

        [Test]
        public void DefaultTests()
        {
            kyu6CountTheDays d = new kyu6CountTheDays();
            Assert.AreEqual("The day is in the past!", d.countDays(new DateTime(2016,12,2)));
            Assert.AreEqual("Today is the day!", d.countDays(DateTime.Now));
        }
    }
}
