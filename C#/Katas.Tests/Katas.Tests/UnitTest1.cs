using NUnit.Framework;
using System;
using System.Collections.Generic;
using Katas;

[TestFixture]
public class GarbleSortTests
{
    [Test]
    public static void TestExample1()
    {
        CollectionAssert.AreEqual(
            new int[] { 1, 3, 2 },
            GarbleSortClass.GarbleSort(new int[] { 1, 2, 3 }));
    }

    [Test]
    public static void TestExample2()
    {
        CollectionAssert.AreEqual(
            new int[] { 6, 3, 5 },
            GarbleSortClass.GarbleSort(new int[] { 5, 6, 3 }));
    }
}