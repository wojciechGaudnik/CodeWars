using System;
using System.Collections;
using Katas;
using NUnit.Framework;
public class StripCommentsTest
{
    [Test]
    public void StripComments()
    {
        Assert.AreEqual(
            "apples, pears\ngrapes\nbananas",
            StripCommentsKata.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" }));

        Assert.AreEqual("a\nc\nd", StripCommentsKata.StripComments("a #b\nc\nd $e f g", new string[] { "#", "$" }));

    }
}