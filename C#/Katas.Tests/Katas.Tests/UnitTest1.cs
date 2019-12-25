using Katas;
using NUnit.Framework;

using Interval = System.ValueTuple<int, int>;

public class IntervalTest
{
    [Test]
    public void ShouldHandleEmptyIntervals()
    {
        Assert.AreEqual(0, SumOfIntervals.SumIntervals(new Interval[] { }));
        Assert.AreEqual(0, SumOfIntervals.SumIntervals(new Interval[] { (4, 4), (6, 6), (8, 8) }));
    }

    [Test]
    public void ShouldAddDisjoinedIntervals()
    {
        Assert.AreEqual(9, SumOfIntervals.SumIntervals(new Interval[] { (1, 2), (6, 10), (11, 15) }));
        Assert.AreEqual(11, SumOfIntervals.SumIntervals(new Interval[] { (4, 8), (9, 10), (15, 21) }));
        Assert.AreEqual(7, SumOfIntervals.SumIntervals(new Interval[] { (-1, 4), (-5, -3) }));
        Assert.AreEqual(78, SumOfIntervals.SumIntervals(new Interval[] { (-245, -218), (-194, -179), (-155, -119) }));
    }

    [Test]
    public void ShouldAddAdjacentIntervals()
    {
        Assert.AreEqual(54, SumOfIntervals.SumIntervals(new Interval[] { (1, 2), (2, 6), (6, 55) }));
        Assert.AreEqual(23, SumOfIntervals.SumIntervals(new Interval[] { (-2, -1), (-1, 0), (0, 21) }));
    }

    [Test]
    public void ShouldAddOverlappingIntervals()
    {
        Assert.AreEqual(7, SumOfIntervals.SumIntervals(new Interval[] { (1, 4), (7, 10), (3, 5) }));
        Assert.AreEqual(6, SumOfIntervals.SumIntervals(new Interval[] { (5, 8), (3, 6), (1, 2) }));
        Assert.AreEqual(19, SumOfIntervals.SumIntervals(new Interval[] { (1, 5), (10, 20), (1, 6), (16, 19), (5, 11) }));
    }

    [Test]
    public void ShouldHandleMixedIntervals()
    {
        Assert.AreEqual(13, SumOfIntervals.SumIntervals(new Interval[] { (2, 5), (-1, 2), (-40, -35), (6, 8) }));
        Assert.AreEqual(1234, SumOfIntervals.SumIntervals(new Interval[] { (-7, 8), (-2, 10), (5, 15), (2000, 3150), (-5400, -5338) }));
        Assert.AreEqual(158, SumOfIntervals.SumIntervals(new Interval[] { (-101, 24), (-35, 27), (27, 53), (-105, 20), (-36, 26) }));
    }
}