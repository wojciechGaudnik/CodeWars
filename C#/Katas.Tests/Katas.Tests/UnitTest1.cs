using Katas;

namespace Solution
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class Sample_Tests
    {
        private static object[] testCases = new object[]
        {
            new object[]
            {
                true,
                new int[][]
                {
                    new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
                    new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
                    new int[] {1, 9, 8, 3, 4, 2, 5, 6, 7},
                    new int[] {8, 5, 9, 7, 6, 1, 4, 2, 3},
                    new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
                    new int[] {7, 1, 3, 9, 2, 4, 8, 5, 6},
                    new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
                    new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
                    new int[] {3, 4, 5, 2, 8, 6, 1, 7, 9},
                },
            },
            new object[]
            {
                false,
                new int[][]
                {
                    new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
                    new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
                    new int[] {1, 9, 8, 3, 0, 2, 5, 6, 7},
                    new int[] {8, 5, 0, 7, 6, 1, 4, 2, 3},
                    new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
                    new int[] {7, 0, 3, 9, 2, 4, 8, 5, 6},
                    new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
                    new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
                    new int[] {3, 0, 0, 2, 8, 6, 1, 7, 9},
                },
            },
        };

        [Test, TestCaseSource("testCases")]
        public void Test(bool expected, int[][] board) => Assert.AreEqual(expected, SudokuSolutionValidator.ValidateSolution(board));
    }
}