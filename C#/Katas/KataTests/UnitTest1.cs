using System;
using System.Collections.Generic;
using System.Linq;
using Katas;
using NUnit.Framework;

[TestFixture]
public class MyTest
{
    [Test]
    public void FirstTest()
    {
        StringAssert.AreEqualIgnoringCase("06:35",kyu6ClockInMirror.WhatIsTheTime("05:25"));
    }

    [Test]
    public void SecondTest()
    {
        StringAssert.AreEqualIgnoringCase("11:59",kyu6ClockInMirror.WhatIsTheTime("12:01"));
    }

    [Test]
    public void ThirdTest()
    {
        StringAssert.AreEqualIgnoringCase("12:02", kyu6ClockInMirror.WhatIsTheTime("11:58"));
    }

    [Test]
    public void FourhTest()
    {
        StringAssert.AreEqualIgnoringCase("12:00", kyu6ClockInMirror.WhatIsTheTime("12:00"));
    }

    [Test]
    public void FifthTest()
    {
        StringAssert.AreEqualIgnoringCase("02:00", kyu6ClockInMirror.WhatIsTheTime("10:00"));
    }
}