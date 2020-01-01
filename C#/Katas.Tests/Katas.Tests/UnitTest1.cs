using System;
using Katas;
using NUnit.Framework;

[TestFixture]
public class SudokuTests {

    [Test]
    public void Test1() {
        var goodSudoku1 = new ValidateSudokuWithSizeNxN(
            new int[][] {
                new int[] {7,8,4, 1,5,9, 3,2,6},
                new int[] {5,3,9, 6,7,2, 8,4,1},
                new int[] {6,1,2, 4,3,8, 7,5,9},

                new int[] {9,2,8, 7,1,5, 4,6,3},
                new int[] {3,5,7, 8,4,6, 1,9,2},
                new int[] {4,6,1, 9,2,3, 5,8,7},

                new int[] {8,7,6, 3,9,4, 2,1,5},
                new int[] {2,4,3, 5,6,1, 9,7,8},
                new int[] {1,9,5, 2,8,7, 6,3,4}
            });
        Assert.IsTrue(goodSudoku1.IsValid());
    }

    [Test]
    public void Test2() {
        var goodSudoku2 = new ValidateSudokuWithSizeNxN(
            new int[][] {
                new int[] {1,4, 2,3},
                new int[] {3,2, 4,1},

                new int[] {4,1, 3,2},
                new int[] {2,3, 1,4}
            });
        Assert.IsTrue(goodSudoku2.IsValid());
    }

    [Test]
    public void Test3() {
        var badSudoku1 = new ValidateSudokuWithSizeNxN(
            new int[][] {
                new int[] {1,2,3, 4,5,6, 7,8,9},
                new int[] {1,2,3, 4,5,6, 7,8,9},
                new int[] {1,2,3, 4,5,6, 7,8,9},

                new int[] {1,2,3, 4,5,6, 7,8,9},
                new int[] {1,2,3, 4,5,6, 7,8,9},
                new int[] {1,2,3, 4,5,6, 7,8,9},

                new int[] {1,2,3, 4,5,6, 7,8,9},
                new int[] {1,2,3, 4,5,6, 7,8,9},
                new int[] {1,2,3, 4,5,6, 7,8,9}
            });
        Assert.IsFalse(badSudoku1.IsValid());
    }

    [Test]
    public void Test4() {
        var badSudoku2 = new ValidateSudokuWithSizeNxN(
            new int[][] {
                new int[] {1,2,3,4,5},
                new int[] {1,2,3,4},

                new int[] {1,2,3,4},
                new int[] {1}
            });
        Assert.IsFalse(badSudoku2.IsValid());
    }
}