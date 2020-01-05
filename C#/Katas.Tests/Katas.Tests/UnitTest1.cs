using Katas;

namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void TestGlider()
        {
            int[][,] gliders =
            {
                new int[,] {{1,0,0},{0,1,1},{1,1,0}},
                new int[,] {{0,1,0},{0,0,1},{1,1,1}}
            };
            Console.WriteLine("Glider");
            int[,] res = ConwaysGameOfLife_UnlimitedEdition.GetGeneration(gliders[0], 1);
            CollectionAssert.AreEqual(gliders[1], res, "Output doesn't match expected");
        }
    }

}