using System;
using Katas;
using NUnit.Framework;

[TestFixture]
public class KataTestf
{
    [Test]
    public void _0_TankState()
    {
        IUnit tank = new Tank();

        Assert.AreEqual(true, tank.CanMove);
        Assert.AreEqual(5, tank.Damage);
    }

    [Test]
    public void _1_SiegeState()
    {
        IUnit tank = new Tank();
        tank.State = new SiegeState();

        Assert.AreEqual(false, tank.CanMove);
        Assert.AreEqual(20, tank.Damage);
    }

    [Test]
    public void _2_MixState()
    {
        IUnit tank = new Tank();

        Assert.AreEqual(true, tank.CanMove);
        tank.State = new SiegeState();
        Assert.AreEqual(20, tank.Damage);
    }
}