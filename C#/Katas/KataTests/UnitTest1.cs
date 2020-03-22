using Katas;

namespace Solution
{
    using NUnit.Framework;

    [TestFixture]
    class kyu6Christmas_treeTests
    {
      	[Test]
      	public void ChristmasTreeTest_0()
      	{
            Assert.AreEqual("", kyu6Christmas_tree.ChristmasTree(0));
      	}
      	[Test]
      	public void ChristmasTreeTest_1()
      	{
        		Assert.AreEqual("*", kyu6Christmas_tree.ChristmasTree(1));
      	}
      	[Test]
      	public void ChristmasTreeTest_2()
      	{
        		Assert.AreEqual(" * \n***", kyu6Christmas_tree.ChristmasTree(2));
      	}
      	[Test]
      	public void ChristmasTreeTest_3()
      	{
        		Assert.AreEqual("  *  \n *** \n*****", kyu6Christmas_tree.ChristmasTree(3));
      	}
      	[Test]
      	public void ChristmasTreeTest_4()
      	{
        		Assert.AreEqual("   *   \n  ***  \n ***** \n*******", kyu6Christmas_tree.ChristmasTree(4));
      	}
      	[Test]
      	public void ChristmasTreeTest_5()
      	{
        		Assert.AreEqual("    *    \n   ***   \n  *****  \n ******* \n*********", kyu6Christmas_tree.ChristmasTree(5));
      	}
      	[Test]
      	public void ChristmasTreeTest_6()
      	{
        		Assert.AreEqual("     *     \n    ***    \n   *****   \n  *******  \n ********* \n***********", kyu6Christmas_tree.ChristmasTree(6));
      	}
      	[Test]
      	public void ChristmasTreeTest_7()
      	{
        		Assert.AreEqual("      *      \n     ***     \n    *****    \n   *******   \n  *********  \n *********** \n*************", kyu6Christmas_tree.ChristmasTree(7));
      	}
      	[Test]
      	public void ChristmasTreeTest_8()
      	{
        		Assert.AreEqual("       *       \n      ***      \n     *****     \n    *******    \n   *********   \n  ***********  \n ************* \n***************", kyu6Christmas_tree.ChristmasTree(8));
      	}
      	[Test]
      	public void ChristmasTreeTest_9()
      	{
        		Assert.AreEqual("        *        \n       ***       \n      *****      \n     *******     \n    *********    \n   ***********   \n  *************  \n *************** \n*****************", kyu6Christmas_tree.ChristmasTree(9));
      	}
      	[Test]
      	public void ChristmasTreeTest_10()
      	{
        		Assert.AreEqual("         *         \n        ***        \n       *****       \n      *******      \n     *********     \n    ***********    \n   *************   \n  ***************  \n ***************** \n*******************", kyu6Christmas_tree.ChristmasTree(10));
      	}
    }
}