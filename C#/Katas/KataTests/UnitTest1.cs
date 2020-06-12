using System;
using KatasMarineWeapon;
using NUnit.Framework;

[TestFixture]
public class KataTest
{
    [Test]
    public void _0_SingleUpgrade()
    {
        IMarine marine = new Marine(10, 1);

        Assert.AreEqual(11, new MarineWeaponUpgrade(marine).Damage);
        Assert.AreEqual(11, new MarineWeaponUpgrade(marine).Damage);
    }

    [Test]
    public void _1_DoubleUpgrade()
    {
        IMarine marine = new Marine(15, 1);
        marine = new MarineWeaponUpgrade(marine);
        marine = new MarineWeaponUpgrade(marine);

        Assert.AreEqual(17, marine.Damage);
    }

    [Test]
    public void _2_TripleUpgrade()
    {
        IMarine marine = new Marine(20, 1);
        marine = new MarineWeaponUpgrade(marine);
        marine = new MarineWeaponUpgrade(marine);
        marine = new MarineWeaponUpgrade(marine);

        Assert.AreEqual(23, marine.Damage);
    }
}