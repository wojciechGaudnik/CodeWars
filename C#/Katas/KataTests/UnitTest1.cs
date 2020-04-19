// using System;
// using System.Collections.Generic;
// using Katas;
// using NUnit.Framework;
//
// [TestFixture]
// public class SimpleHtmlColorParserTest : AssertionHelper
// {
//     private readonly kyu6ParseHTML_CSSColors parser = new kyu6ParseHTML_CSSColors(PresetColors.Map);
//
//     [Test]
//     public void ExampleTests()
//     {
//         ShouldParse("#80FFA0",   new RGB(128, 255, 160));
//         ShouldParse("#3B7",      new RGB( 51, 187, 119));
//         ShouldParse("LimeGreen", new RGB( 50, 205,  50));
//     }
//
//     // A helper function for the testing.
//     private void ShouldParse(string color, RGB expected)
//     {
//         Assert.AreEqual(expected, parser.Parse(color), $"input: \"{color}\"");
//     }
// }
