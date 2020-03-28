using NUnit.Framework;
using System;
using Katas;

[TestFixture]
public class OrderTest
{
    [Test]
    public void Test1()
    {
        Assert.AreEqual("Burger Fries Chicken Pizza Pizza Pizza Sandwich Milkshake Milkshake Coke",
            kyuNewCashierDoesNotKnowAboutSpaceOrShift.GetOrder("milkshakepizzachickenfriescokeburgerpizzasandwichmilkshakepizza"));
    }

    [Test]
    public void Test2()
    {
        Assert.AreEqual("Burger Fries Fries Chicken Pizza Sandwich Milkshake Coke",
            kyuNewCashierDoesNotKnowAboutSpaceOrShift.GetOrder("pizzachickenfriesburgercokemilkshakefriessandwich"));
    }
}