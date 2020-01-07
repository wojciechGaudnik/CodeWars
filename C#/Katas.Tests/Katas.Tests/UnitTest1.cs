using Katas;
using NUnit.Framework;
public class BefungeInterpreterBasicTests
{
    [Test]
    public void Test1()
    {
        Assert.AreEqual(
            "123456789",
            new BefungeInterpreter().Interpret(">987v>.v\nv456<  :\n>321 ^ _@"));
    }

    [Test]
    public void Test2()
    {
        Assert.AreEqual(
            "40320",
            new BefungeInterpreter().Interpret("08>:1-:v v *_$.@ \n  ^    _$>\\:^  ^    _$>\\:^"));
    }

    [Test]
    public void Test3()
    {
        Assert.AreEqual(
            "Hello World!\n",
            new BefungeInterpreter().Interpret(">25*\"!dlroW olleH\":v\n                v:,_@\n                >  ^"));
    }

    [Test]
    public void Test4()
    {
        Assert.AreEqual(
            "01->1# +# :# 0# g# ,# :# 5# 8# *# 4# +# -# _@",
            new BefungeInterpreter().Interpret("01->1# +# :# 0# g# ,# :# 5# 8# *# 4# +# -# _@"));
    }

    [Test]
    public void Test5()
    {
        Assert.AreEqual(
            "A",
            new BefungeInterpreter().Interpret("665+*1-,@"));
    }

    [Test]
    public void Test6()
    {
        Assert.AreEqual(
            "65",
            new BefungeInterpreter().Interpret("665+*1-.@"));
    }
}