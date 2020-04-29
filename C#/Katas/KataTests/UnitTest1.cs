// using Katas;
//
// namespace Tree {
//
//     using NUnit.Framework;
//     using System;
//
//     [TestFixture]
//     public class SolutionTest
//     {
//         /**
//      * null
//      */
//         [Test]
//         public void MaxSumInNullTree()
//         {
//             TreeNode root = null;
//             Assert.AreEqual(0, Solution.MaxSum(root));
//         }
//
//         /**
//      *      5//      *    /   \
//      *  -22    11
//      *  / \    / \
//      * 9  50  9   2
//      */
//         [Test]
//         public void MaxSumInPerfectTree()
//         {
//             TreeNode left = TreeNode.Leaf(-22).WithLeaves(9, 50);
//             TreeNode right = TreeNode.Leaf(11).WithLeaves(9, 2);
//             TreeNode root = TreeNode.Join(5, left, right);
//             Assert.AreEqual(33, Solution.MaxSum(root));
//         }
//     }
// }