using System.Collections.Generic;
using NUnit.Framework;

namespace Katas.Tests
{
    [TestFixture]
    public class SkyScrapersTests
    {
        SkyScrapersAll kata = new SkyScrapersAll();

        //todo wrong <------------------------------------------------------------------------------------------------------
        [Test]
        public void CheckIfWrong1()
        {
            string[] forTest = {"4", "3", "2", "1"};
            var clue = 2;
            var expected = true;
            Assert.AreEqual(expected, SkyScrapersAll.IsWrongClue(forTest, clue, 4));
        }

        [Test]
        public void CheckIfWrong2()
        {
            string[] forTest = {"1", "4", "3", "2"};
            var clue = 2;
            var expected = true;
            Assert.AreEqual(expected, SkyScrapersAll.IsWrongClue(forTest, clue, 4));
        }

        [Test]
        public void CheckIfWrong3()
        {
            string[] forTest = {"2", "3", "4", "1"};
            var clue = 2;
            var expected = false;
            Assert.AreEqual(expected, SkyScrapersAll.IsWrongClue(forTest, clue, 4));
        }

        [Test]
        public void CheckIfWrong4()
        {
            string[] forTest = {"1234", "123", "1236", "1", "13456", "2345"};
            var clue = 3;
            var expected = false;
            Assert.AreEqual(expected, SkyScrapersAll.IsWrongClue(forTest, clue, 4));
        }

        [Test]
        public void CheckIfWrong5()
        {
            string[] forTest = {"4", "5", "2", "6", "1", "3"};
            var clue = 3;
            var expected = true;
            Assert.AreEqual(expected, SkyScrapersAll.IsWrongClue(forTest, clue, 6));
        }

        [Test]
        public void CheckIfWrong6()
        {
            string[] forTest = {"3", "1", "6", "2", "5", "4"};
            var clue = 3;
            var expected = false;
            Assert.AreEqual(expected, SkyScrapersAll.IsWrongClue(forTest, clue, 6));
        }

        [Test]
        public void CheckIfWrong7()
        {
            string[] forTest = {"6", "13", "5", "123", "4", "123"};
            var clue = 4;
            var expected = false;
            Assert.AreEqual(expected, SkyScrapersAll.IsWrongClue(forTest, clue, 6));
        }

        [Test]
        public void CheckIfWrong8()
        {
            string[] forTest = {"3", "2", "14", "1"};
            var clue = 2;
            var expected = false;
            Assert.AreEqual(expected, SkyScrapersAll.IsWrongClue(forTest, clue, 4));
        }


        //todo CluesTwoSet <------------------------------------------------------------------------------------------------
        [Test]
        public void CluesTwo1()
        {
            // todo if max is not set and
            // todo if first to edge is set
            // todo and rest set is in order then first not set set max
            string[] forTest = {"1234", "1234", "1234", "1"};
            string[] expected = {"1234", "1234", "4", "1"};
            SkyScrapersAll.SetHighestNextToAdjacentClueTwoLogic(ref forTest, 4);
            Assert.AreEqual(expected, forTest);
        }

        [Test]
        public void CluesTwo2()
        {
            string[] forTest = {"34", "34", "1", "2"};
            string[] expected = {"34", "4", "1", "2"};
            SkyScrapersAll.SetHighestNextToAdjacentClueTwoLogic(ref forTest, 4);
            Assert.AreEqual(expected, forTest);
        }

        [Test]
        public void CluesTwo3()
        {
            string[] forTest = {"1", "34", "34", "2"};
            string[] expected = {"1", "34", "4", "2"};
            SkyScrapersAll.SetHighestNextToAdjacentClueTwoLogic(ref forTest, 4);
            Assert.AreEqual(expected, forTest);
        }

        [Test]
        public void CluesTwo4()
        {
            string[] forTest = {"24", "24", "1", "3"};
            var answer = SkyScrapersAll.SetHighestNextToAdjacentClueTwoLogic(ref forTest, 4);
            Assert.AreEqual(false, answer);
        }

        [Test]
        public void CluesTwo5()
        {
            string[] forTest = {"1234", "1234", "1", "2"};
            SkyScrapersAll.SetHighestNextToAdjacentClueTwoLogic(ref forTest, 4);
            string[] expected = {"1234", "4", "1", "2"};
            Assert.AreEqual(expected, forTest);
        }

        [Test]
        public void CluesTwo6()
        {
            string[] forTest = {"134", "134", "134", "2"};
            var answer = SkyScrapersAll.SetHighestNextToAdjacentClueTwoLogic(ref forTest, 4);
            Assert.AreEqual(false, answer);
        }

        [Test]
        public void CluesTwo7()
        {
            string[] forTest = {"26", "26", "1", "3", "4", "5"};
            var test = SkyScrapersAll.SetHighestNextToAdjacentClueTwoLogic(ref forTest, 6);
            Assert.AreEqual(false, test);
        }

        [Test]
        public void CluesTwoTodo0()
        {
            string[] forTest = {"3456", "3456", "3456", "3456", "12", "12"};
            var answer = SkyScrapersAll.SetHighestNextToAdjacentClueTwoLogic(ref forTest, 6);
            Assert.AreEqual(false, answer);
        }

        [Test]
        public void CluesTwoTodo1()
        {
            string[] forTest = {"12", "56", "56", "56", "3", "4"};
            var answer = SkyScrapersAll.SetHighestNextToAdjacentClueTwoLogic(ref forTest, 6);
            Assert.AreEqual(false, answer);
        }

        [Test]
        public void CluesTwoTodo2()
        {
            string[] forTest = {"12", "36", "56", "12", "12", "4"};
            var answer = SkyScrapersAll.SetHighestNextToAdjacentClueTwoLogic(ref forTest, 6);
            Assert.AreEqual(false, answer);
        }

        [Test]
        public void CluesTwoOK()
        {
            string[] forTest = {"1245", "124", "1245", "3", "6", "1245"};
            var answer = SkyScrapersAll.SetHighestNextToAdjacentClueTwoLogic(ref forTest, 6);
            Assert.AreEqual(false, answer);
        }

        [Test]
        public void CluesTwoSecond1()
        {
            string[] forTest = {"3", "4", "12", "12"};
            string[] expected = {"3", "4", "12", "2"};
            SkyScrapersAll.SetSecondHighestOppositeClueTwoLogic(ref forTest, 4);
            Assert.AreEqual(expected, forTest);
        }

        [Test]
        public void CluesTwoSecond2()
        {
            string[] forTest = {"123", "4", "123", "123"};
            var answer = SkyScrapersAll.SetSecondHighestOppositeClueTwoLogic(ref forTest, 4);
            Assert.AreEqual(false, answer);
        }

        [Test]
        public void CluesTwoSecond3Todo()
        {
            string[] forTest = {"12", "12", "6", "1345", "345", "1234"};
            var answer = SkyScrapersAll.SetSecondHighestOppositeClueTwoLogic(ref forTest, 6);
            Assert.AreEqual(false, answer);
        }

        [Test]
        public void CluesTwoSecond4Todo()
        {
            string[] forTest = {"12", "12", "6", "1345", "1345", "1345"};
            var answer = SkyScrapersAll.SetSecondHighestOppositeClueTwoLogic(ref forTest, 6);
            Assert.AreEqual(false, answer);
        }


        //todo developmental <----------------------------------------------------------------------------------------------
        [Test]
        public void DevelopmentalZero()
        {
            int[] cluesForTest =  {0, 0, 0, 2, 0, 3,   0, 0, 0, 3, 4, 0,    0, 3, 2, 0, 0, 5,    0, 0, 4, 0, 0, 0};
            int[] upClues;
            int[] rightClues;
            int[] bottomClues;
            int[] leftClues;
            SkyScrapersAll.SetClues(cluesForTest, out upClues, out rightClues, out bottomClues, out leftClues);

            string[][] expected =
            {
                new [] {"6", "1", "2", "3", "5", "4"},
                new [] {"5", "3", "4", "1", "6", "2"},
                new [] {"4", "6", "3", "2", "1", "5"},
                new [] {"1", "2", "5", "6", "4", "3"},
                new [] {"3", "5", "6", "4", "2", "1"},
                new [] {"2", "4", "1", "5", "3", "6"}
            };
            Assert.AreEqual(true, SkyScrapersAll.IsBoardDevelopmental(expected, upClues, rightClues, bottomClues, leftClues, 6));
            var dictFortest = new Dictionary<int[], string>();
            dictFortest.Add(new int[]{1,1}, "3");
            Assert.AreEqual(true, SkyScrapersAll.SolvePuzzle(cluesForTest, true, dictFortest).Length != 1);
        }

        [Test]
        public void DevelopmentalOne()
        {
            int[] cluesForTest =  {0, 0, 0, 3, 4, 0,    0, 3, 2, 0, 0, 5,    0, 0, 4, 0, 0, 0,    0, 0, 0, 2, 0, 3};
            int[] upClues;
            int[] rightClues;
            int[] bottomClues;
            int[] leftClues;
            SkyScrapersAll.SetClues(cluesForTest, out upClues, out rightClues, out bottomClues, out leftClues);

            string[][] expected =
            {
                new [] {"6", "1", "2", "3", "5", "4"},
                new [] {"5", "3", "4", "1", "6", "2"},
                new [] {"4", "6", "3", "2", "1", "5"},
                new [] {"1", "2", "5", "6", "4", "3"},
                new [] {"3", "5", "6", "4", "2", "1"},
                new [] {"2", "4", "1", "5", "3", "6"}
            };
            expected = RotateLeft(expected);
            Assert.AreEqual(true, SkyScrapersAll.IsBoardDevelopmental(expected, upClues, rightClues, bottomClues, leftClues, 6));
            var dictFortest = new Dictionary<int[], string>();
            dictFortest.Add(new int[]{4,1}, "3");
            Assert.AreEqual(true, SkyScrapersAll.SolvePuzzle(cluesForTest, true, dictFortest).Length != 1);
        }

        [Test]
        public void DevelopmentalTwo()
        {
            int[] cluesForTest =  {0, 3, 2, 0, 0, 5,    0, 0, 4, 0, 0, 0,    0, 0, 0, 2, 0, 3,   0, 0, 0, 3, 4, 0};
            int[] upClues;
            int[] rightClues;
            int[] bottomClues;
            int[] leftClues;
            SkyScrapersAll.SetClues(cluesForTest, out upClues, out rightClues, out bottomClues, out leftClues);

            string[][] expected =
            {
                new [] {"6", "1", "2", "3", "5", "4"},
                new [] {"5", "3", "4", "1", "6", "2"},
                new [] {"4", "6", "3", "2", "1", "5"},
                new [] {"1", "2", "5", "6", "4", "3"},
                new [] {"3", "5", "6", "4", "2", "1"},
                new [] {"2", "4", "1", "5", "3", "6"}
            };
            expected = RotateLeft(expected);
            expected = RotateLeft(expected);
            Assert.AreEqual(true, SkyScrapersAll.IsBoardDevelopmental(expected, upClues, rightClues, bottomClues, leftClues, 6));
            var dictFortest = new Dictionary<int[], string>();
            Assert.AreEqual(true, SkyScrapersAll.SolvePuzzle(cluesForTest, true, dictFortest).Length != 1);
        }

        [Test]
        public void DevelopmentalTree()
        {
            int[] cluesForTest =  {0, 0, 4, 0, 0, 0,    0, 0, 0, 2, 0, 3,   0, 0, 0, 3, 4, 0,   0, 3, 2, 0, 0, 5};
            int[] upClues;
            int[] rightClues;
            int[] bottomClues;
            int[] leftClues;
            SkyScrapersAll.SetClues(cluesForTest, out upClues, out rightClues, out bottomClues, out leftClues);

            string[][] expected =
            {
                new [] {"6", "1", "2", "3", "5", "4"},
                new [] {"5", "3", "4", "1", "6", "2"},
                new [] {"4", "6", "3", "2", "1", "5"},
                new [] {"1", "2", "5", "6", "4", "3"},
                new [] {"3", "5", "6", "4", "2", "1"},
                new [] {"2", "4", "1", "5", "3", "6"}
            };
            expected = RotateLeft(expected);
            expected = RotateLeft(expected);
            expected = RotateLeft(expected);
            Assert.AreEqual(true, SkyScrapersAll.IsBoardDevelopmental(expected, upClues, rightClues, bottomClues, leftClues, 6));
        }

        [Test]
        public void DevelopmentalBug()
        {
            int[] cluesForTest =  {0, 0, 0, 0,    0, 2, 0, 0,    2, 0, 0, 0,   0, 3, 0, 3};
            int[] upClues;
            int[] rightClues;
            int[] bottomClues;
            int[] leftClues;
            SkyScrapersAll.SetClues(cluesForTest, out upClues, out rightClues, out bottomClues, out leftClues);

            string[][] board =
            {
                new [] {"1", "2", "4", "3"},
                new [] {"3", "4", "1", "2"},
                new [] {"2", "13", "3", "14"},
                new [] {"4", "13", "2", "1"},
            };
            Assert.AreEqual(true, SkyScrapersAll.IsBoardDevelopmental(board, upClues, rightClues, bottomClues, leftClues, 4));
        }


        //todo whole <------------------------------------------------------------------------------------------------------
        [Test]
        public void WholeBoard4x4_1()
        {
            int[] cluesForTest = {0, 1, 0, 0, 0, 0, 1, 2, 0, 2, 0, 0, 0, 3, 0, 0};
            int[][] expected =
            {
                new [] {1, 4, 3, 2},
                new [] {3, 2, 4, 1},
                new [] {2, 3, 1, 4},
                new [] {4, 1, 2, 3}
            };
            Assert.AreEqual(expected, SkyScrapersAll.SolvePuzzle(cluesForTest, false));
        }

        [Test]
        public void WholeBoard4x4_2()
        {
            int[] cluesForTest = {0, 0, 1, 2, 0, 2, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0};
            int[][] expected =
            {
                new [] {2, 1, 4, 3},
                new [] {3, 4, 1, 2},
                new [] {4, 2, 3, 1},
                new [] {1, 3, 2, 4}
            };
            Assert.AreEqual(expected, SkyScrapersAll.SolvePuzzle(cluesForTest, false));
        }

        [Test]
        public void WholeBoard4x4_3()
        {
            int[] cluesForTest = {0, 2, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 0, 1, 2};
            int[][] expected =
            {
                new [] {3, 2, 1, 4},
                new [] {4, 1, 3, 2},
                new [] {1, 4, 2, 3},
                new [] {2, 3, 4, 1}
            };
            Assert.AreEqual(expected, SkyScrapersAll.SolvePuzzle(cluesForTest, false));
        }

        [Test]
        public void WholeBoard4x4_4()
        {
            int[] cluesForTest = {0, 3, 0, 0, 0, 1, 0, 0, 0, 0, 1, 2, 0, 2, 0, 0};
            int[][] expected =
            {
                new [] {4, 2, 3, 1},
                new [] {1, 3, 2, 4},
                new [] {2, 1, 4, 3},
                new [] {3, 4, 1, 2}
            };
            Assert.AreEqual(expected, SkyScrapersAll.SolvePuzzle(cluesForTest, false));
        }

        [Test]
        public void WholeBoard4x4_5()
        {
            int[] cluesForTest =  {0, 0, 0, 0,    2, 0, 0, 1,    0, 2, 0, 2,    0, 0, 1, 0};
            int[][] expected =
            {
                new [] {2, 4, 1, 3},
                new [] {4, 2, 3, 1},
                new [] {1, 3, 4, 2},
                new [] {3, 1, 2, 4}
            };
            Assert.AreEqual(expected, SkyScrapersAll.SolvePuzzle(cluesForTest));
        }

        [Test]
        public void WholeBoard4x4_6()
        {
            int[] cluesForTest =  {0, 0, 0, 0,    0, 0, 1, 0,    0, 0, 2, 2,    0, 0, 0, 2};
            int[][] expected =
            {
                new [] {3, 4, 1, 2},
                new [] {4, 1, 2, 3},
                new [] {1, 2, 3, 4},
                new [] {2, 3, 4, 1}
            };
            Assert.AreEqual(expected, SkyScrapersAll.SolvePuzzle(cluesForTest));
        }

        [Test]
        public void WholeBoard6x6_ScanAllStepOne()
        {
            int[] cluesForTest =
                {0, 0, 0, 2, 2, 0, 0, 0, 0, 6, 3, 0, 0, 4, 0, 0, 0, 0, 4, 4, 0, 3, 0, 0}; //todo <--- good
            int[][] expected =
            {
                new [] {1235,  1236, 1236, 4,  135,   235},
                new [] {12345, 1236, 1236, 12, 1346,  2345},
                new [] {1234,  123,  1236, 12, 13456, 2345},
                new [] {6,     5,    4,    3,  2,     1},
                new [] {123,   123,  5,    6,  134,   234},
                new [] {123,   4,    123,  5,  13,    6}
            };
            Assert.AreEqual(expected, SkyScrapersAll.SolvePuzzle(cluesForTest, false));
        }

        [Test]
        public void WholeBoard6x6_ScanAllStepTwo()
        {
            int[] cluesForTest = {0, 0, 0, 6, 3, 0, 0, 4, 0, 0, 0, 0, 4, 4, 0, 3, 0, 0, 0, 0, 0, 2, 2, 0};  //todo <--- good
            int[][] expected =
            {
                new [] {1235, 1236, 1236, 4, 135, 235},
                new [] {12345, 1236, 1236, 12, 1346, 2345},
                new [] {1234, 123, 1236, 12, 13456, 2345},
                new [] {6, 5, 4, 3, 2, 1},
                new [] {123, 123, 5, 6, 134, 234},
                new [] {123, 4, 123, 5, 13, 6}
            };
            expected = RotateLeft(expected);
            Assert.AreEqual(expected, SkyScrapersAll.SolvePuzzle(cluesForTest, false));
        }

        [Test]
        public void WholeBoard6x6_ScanAllStepThree()
        {
            int[] cluesForTest = {0, 4, 0, 0, 0, 0, 4, 4, 0, 3, 0, 0, 0, 0, 0, 2, 2, 0, 0, 0, 0, 6, 3, 0};  //todo <--- good
            int[][] expected =
            {
                new [] {1235, 1236, 1236, 4, 135, 235},
                new [] {12345, 1236, 1236, 12, 1346, 2345},
                new [] {1234, 123, 1236, 12, 13456, 2345},
                new [] {6, 5, 4, 3, 2, 1},
                new [] {123, 123, 5, 6, 134, 234},
                new [] {123, 4, 123, 5, 13, 6}
            };
            expected = RotateLeft(expected);
            expected = RotateLeft(expected);
            Assert.AreEqual(expected, SkyScrapersAll.SolvePuzzle(cluesForTest, false));
        }

        [Test]
        public void WholeBoard6x6_ScanAllStepFour()
        {
            int[] cluesForTest = {4, 4, 0, 3, 0, 0, 0, 0, 0, 2, 2, 0, 0, 0, 0, 6, 3, 0, 0, 4, 0, 0, 0, 0};  //todo <--- good
            int[][] expected =
            {
                new [] {1235, 1236, 1236, 4, 135, 235},
                new [] {12345, 1236, 1236, 12, 1346, 2345},
                new [] {1234, 123, 1236, 12, 13456, 2345},
                new [] {6, 5, 4, 3, 2, 1},
                new [] {123, 123, 5, 6, 134, 234},
                new [] {123, 4, 123, 5, 13, 6}
            };
            expected = RotateLeft(expected);
            expected = RotateLeft(expected);
            expected = RotateLeft(expected);
            Assert.AreEqual(expected, SkyScrapersAll.SolvePuzzle(cluesForTest, false));
        }

        [Test]
        public void WholeBoard6x6_ScanAllStepFive1()
        {
            int[] cluesForTest = {0, 0, 0, 2, 2, 0,    0, 0, 0, 6, 3, 0,    0, 4, 0, 0, 0, 0,    4, 4, 0, 3, 0, 0};
            int[][] expected =
            {
                new [] {5, 6, 1, 4, 3, 2},
                new [] {4, 1, 3, 2, 6, 5},
                new [] {2, 3, 6, 1, 5, 4},
                new [] {6, 5, 4, 3, 2, 1},
                new [] {1, 2, 5, 6, 4, 3},
                new [] {3, 4, 2, 5, 1, 6}
            };
            Assert.AreEqual(expected, SkyScrapersAll.SolvePuzzle(cluesForTest));
        }

        [Test]
        public void WholeBoard6x6_ScanAllStepFive2()
        {
            int[] cluesForTest = {0, 0, 0, 6, 3, 0,    0, 4, 0, 0, 0, 0,    4, 4, 0, 3, 0, 0,    0, 0, 0, 2, 2, 0};
            int[][] expected =
            {
                new [] {5, 6, 1, 4, 3, 2},
                new [] {4, 1, 3, 2, 6, 5},
                new [] {2, 3, 6, 1, 5, 4},
                new [] {6, 5, 4, 3, 2, 1},
                new [] {1, 2, 5, 6, 4, 3},
                new [] {3, 4, 2, 5, 1, 6}
            };
            expected = RotateLeft(expected);
            Assert.AreEqual(expected, SkyScrapersAll.SolvePuzzle(cluesForTest));
        }

        [Test]
        public void WholeBoard6x6_ScanAllStepFive3()
        {
            int[] cluesForTest = {0, 4, 0, 0, 0, 0,    4, 4, 0, 3, 0, 0,    0, 0, 0, 2, 2, 0,    0, 0, 0, 6, 3, 0};
            int[][] expected =
            {
                new [] {5, 6, 1, 4, 3, 2},
                new [] {4, 1, 3, 2, 6, 5},
                new [] {2, 3, 6, 1, 5, 4},
                new [] {6, 5, 4, 3, 2, 1},
                new [] {1, 2, 5, 6, 4, 3},
                new [] {3, 4, 2, 5, 1, 6}
            };
            expected = RotateLeft(expected);
            expected = RotateLeft(expected);
            Assert.AreEqual(expected, SkyScrapersAll.SolvePuzzle(cluesForTest));
        }

        [Test]
        public void WholeBoard6x6_ScanAllStepFive4()
        {
            int[] cluesForTest = {4, 4, 0, 3, 0, 0,    0, 0, 0, 2, 2, 0,    0, 0, 0, 6, 3, 0,    0, 4, 0, 0, 0, 0};
            int[][] expected =
            {
                new [] {5, 6, 1, 4, 3, 2},
                new [] {4, 1, 3, 2, 6, 5},
                new [] {2, 3, 6, 1, 5, 4},
                new [] {6, 5, 4, 3, 2, 1},
                new [] {1, 2, 5, 6, 4, 3},
                new [] {3, 4, 2, 5, 1, 6}
            };
            expected = RotateLeft(expected);
            expected = RotateLeft(expected);
            expected = RotateLeft(expected);
            Assert.AreEqual(expected, SkyScrapersAll.SolvePuzzle(cluesForTest));
        }

        [Test]
        public void WholeBoard6x6_WithReadySetsLeftZero()
        {
            int[] cluesForTest =  {3, 0, 3, 3, 0, 0,    0, 1, 3, 0, 2, 0,    0, 3, 2, 0, 4, 0,    0, 0, 0, 3, 0, 0};
            var dictFortest = new Dictionary<int[], string>();
            dictFortest.Add(new int[]{4,1}, "3");
            dictFortest.Add(new int[]{5,2}, "2");


            int[][] expected =
            {
                new [] {4, 6, 3, 1, 5, 2},
                new [] {2, 4, 5, 3, 1, 6},
                new [] {3, 5, 4, 6, 2, 1},
                new [] {5, 2, 1, 4, 6, 3},
                new [] {1, 3, 6, 2, 4, 5},
                new [] {6, 1, 2, 5, 3, 4},
            };
            Assert.AreEqual(expected, SkyScrapersAll.SolvePuzzle(cluesForTest, true, dictFortest));
        }

        [Test]
        public void WholeBoard6x6_WithReadySetsLeftOne()
        {
            int[] cluesForTest =  {0, 1, 3, 0, 2, 0,    0, 3, 2, 0, 4, 0,    0, 0, 0, 3, 0, 0,    3, 0, 3, 3, 0, 0};
            var dictFortest = new Dictionary<int[], string>();
            dictFortest.Add(new int[]{4,4}, "3");
            dictFortest.Add(new int[]{3,5}, "2");

            int[][] expected =
            {
                new [] {4, 6, 3, 1, 5, 2},
                new [] {2, 4, 5, 3, 1, 6},
                new [] {3, 5, 4, 6, 2, 1},
                new [] {5, 2, 1, 4, 6, 3},
                new [] {1, 3, 6, 2, 4, 5},
                new [] {6, 1, 2, 5, 3, 4},
            };
            expected = RotateLeft(expected);
            Assert.AreEqual(expected, SkyScrapersAll.SolvePuzzle(cluesForTest, true, dictFortest));
        }

        [Test]
        public void WholeBoard6x6_WithReadySetsLeftTwoZero()
        {
            int[] cluesForTest =  {0, 0, 0, 2, 0, 3,    0, 0, 0, 3, 4, 0,    0, 3, 2, 0, 0, 5,    0, 0, 4, 0, 0, 0};
            var dictFortest = new Dictionary<int[], string>();
            dictFortest.Add(new int[]{1,1}, "3");


            int[][] expected =
            {
                new [] {6, 1, 2, 3, 5, 4},
                new [] {5, 3, 4, 1, 6, 2},
                new [] {4, 6, 3, 2, 1, 5},
                new [] {1, 2, 5, 6, 4, 3},
                new [] {3, 5, 6, 4, 2, 1},
                new [] {2, 4, 1, 5, 3, 6}
            };
            Assert.AreEqual(expected, SkyScrapersAll.SolvePuzzle(cluesForTest, true, dictFortest));
        }

        [Test]
        public void WholeBoard6x6_WithReadySetsLeftTwoOne()
        {
            int[] cluesForTest =  {0, 0, 0, 3, 4, 0,    0, 3, 2, 0, 0, 5,    0, 0, 4, 0, 0, 0,    0, 0, 0, 2, 0, 3};
            var dictFortest = new Dictionary<int[], string>();
            dictFortest.Add(new int[]{4,1}, "3");


            int[][] expected =
            {
                new [] {6, 1, 2, 3, 5, 4},
                new [] {5, 3, 4, 1, 6, 2},
                new [] {4, 6, 3, 2, 1, 5},
                new [] {1, 2, 5, 6, 4, 3},
                new [] {3, 5, 6, 4, 2, 1},
                new [] {2, 4, 1, 5, 3, 6}
            };
            expected = RotateLeft(expected);
            Assert.AreEqual(expected, SkyScrapersAll.SolvePuzzle(cluesForTest, true, dictFortest));
        }

        [Test]
        public void WholeBoard6x6_WithReadySetsLeftTwoTwo()
        {
            int[] cluesForTest =  {0, 3, 2, 0, 0, 5,    0, 0, 4, 0, 0, 0,    0, 0, 0, 2, 0, 3,    0, 0, 0, 3, 4, 0};
            var dictFortest = new Dictionary<int[], string>();
            dictFortest.Add(new int[]{4,4}, "3");


            int[][] expected =
            {
                new [] {6, 1, 2, 3, 5, 4},
                new [] {5, 3, 4, 1, 6, 2},
                new [] {4, 6, 3, 2, 1, 5},
                new [] {1, 2, 5, 6, 4, 3},
                new [] {3, 5, 6, 4, 2, 1},
                new [] {2, 4, 1, 5, 3, 6}
            };
            expected = RotateLeft(expected);
            expected = RotateLeft(expected);
            Assert.AreEqual(expected, SkyScrapersAll.SolvePuzzle(cluesForTest, true, dictFortest));
        }

        [Test]
        public void WholeBoard6x6_WithReadySetsLeftTwo()
        {
            int[] cluesForTest =  {0, 3, 2, 0, 4, 0,    0, 0, 0, 3, 0, 0,    3, 0, 3, 3, 0, 0,    0, 1, 3, 0, 2, 0};
            var dictFortest = new Dictionary<int[], string>();
            dictFortest.Add(new int[]{1,4}, "3");
            dictFortest.Add(new int[]{0,3}, "2");


            int[][] expected =
            {
                new [] {4, 6, 3, 1, 5, 2},
                new [] {2, 4, 5, 3, 1, 6},
                new [] {3, 5, 4, 6, 2, 1},
                new [] {5, 2, 1, 4, 6, 3},
                new [] {1, 3, 6, 2, 4, 5},
                new [] {6, 1, 2, 5, 3, 4},
            };
            expected = RotateLeft(expected);
            expected = RotateLeft(expected);
            Assert.AreEqual(expected, SkyScrapersAll.SolvePuzzle(cluesForTest, true, dictFortest));
        }

        public T[][] RotateLeft<T>(T[][] board)
        {
            var Max = board.Length;
            var answer = new T[Max][];
            var i = 0;
            for (var x = Max - 1; x >= 0; x--)
            {
                answer[i] = new T[Max];
                for (var y = 0; y < Max; y++)
                {
                    answer[i][y] = board[y][x];
                }
                i++;
            }
            return answer;
        }

    }
}