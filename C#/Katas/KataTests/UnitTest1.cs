using NUnit.Framework;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Katas;

[TestFixture]
public class BingoCardTests
{
    [Test]
    public void CardHas24Numbers()
    {
        Assert.AreEqual(24, kyu6BingoCard.GetCard().Length);
    }

    [Test]
    public void EachNumberOnCardIsUnique()
    {
        var card = kyu6BingoCard.GetCard();
        Assert.AreEqual(card.Length, card.ToList().Distinct().Count());
    }

    [TestCase("B", 5)]
    [TestCase("I", 5)]
    [TestCase("N", 4)]
    [TestCase("G", 5)]
    [TestCase("O", 5)]
    public void ColumnContainsCorrectNumberOfItems(string column, int count)
    {
        var numbers = kyu6BingoCard.GetCard().Where(x => x.StartsWith(column)).ToList();
        Assert.AreEqual(count, numbers.Count);
    }

    [Test]
    public void NumbersAreOrderedByColumn()
    {
        var columns = string.Join("", kyu6BingoCard.GetCard().ToList()
            .Select(x => x.Substring(0, 1)).ToArray());

        Assert.IsTrue(Regex.IsMatch(columns, "^[B]*[I]*[N]*[G]*[O]*$"));
    }

    [TestCase("B", 1, 15)]
    [TestCase("I", 16, 30)]
    [TestCase("N", 31, 45)]
    [TestCase("G", 46, 60)]
    [TestCase("O", 61, 75)]
    public void NumbersWithinColumnAreAllInTheCorrectRange(string column, int start, int end)
    {
        var numbers = kyu6BingoCard.GetCard().Where(x => x.StartsWith(column)).ToList();

        foreach (var number in numbers)
        {
            var n = Convert.ToInt32(number.Substring(1));
            Assert.GreaterOrEqual(n, start, "Column {0} should be in the range between {1} and {2}, found: {3}", column, start, end, number);
            Assert.LessOrEqual(n, end, "Column {0} should be in the range between {1} and {2}, found: {3}", column, start, end, number);
        }
    }

    [Test]
    public void NumbersWithinColumnAreInRandomOrder()
    {
        var card = kyu6BingoCard.GetCard().Select(x => Convert.ToInt32(x.Substring(1))).ToArray();

        var isRandom = false;
        for (var i = 1; i < card.Length; i++)
        {
            if (card[i - 1] > card[i])
            {
                isRandom = true;
                break;
            }
        }

        Assert.IsTrue(isRandom, "Unlikely result, is the list ordered?");
    }
}
