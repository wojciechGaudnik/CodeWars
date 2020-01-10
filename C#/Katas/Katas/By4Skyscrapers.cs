using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class By4Skyscrapers
    {
        public static void Main(string[] args)
        {
            // var test = "String";
            var test = "Abcdefghijklł";
            var stringArray = test.ToCharArray();
            for (var i = 0; i < 100; i++)
            {
                stringArray = Roll(stringArray, 0);
                Console.WriteLine(string.Join("", stringArray));
                if(string.Join("", stringArray) == test) break;
            }

            var a = 10;
            var b = 40;
            var answer = string.Join(", ", Enumerable.Range(a, b - a + 1));
            Console.WriteLine(answer);







            // var x = 6;
            // var test = Enumerable.Range(2, x - 1).Where(n => n % 2 == 0).Any(e => (x - 2) != 0 && (x - e) % 2  == 0);
            // Console.WriteLine(SolvePuzzle(new int[16]{0, 0, 1, 2, 0, 2, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0}));
        }

        public static int[] Between(int a, int b)
        {
            return Enumerable.Range(a, b - a + 1).ToArray();
        }



        public static char[] Roll(char[] word, int n)
        {
            if (n < word.Length)
            {
                var partFirst = word[Range.EndAt(n)];
                var partSecond = word[Range.StartAt(n)];
                Array.Reverse(partSecond);
                word = partFirst.Concat(partSecond).ToArray();
                return Roll(word, n + 1);
            }
            return word;
        }

        const int MaxY = 4, MaxX = 4, MAXNUMBERS = 4;

        public static int[][] SolvePuzzle(int[] clues)
        {
            int[][][] board;
            MakeEmptyBoard(out board, clues);










            var countClues = 0;
            for (var x = 0; x < board[0].Length; x++)
            {
                if (clues[countClues] != 0)
                {
                    if (clues[countClues++] == 1)
                    {
                        Console.WriteLine(board[0][x][countClues].GetType());
                        board[0][x][countClues] = 11;
                        // new int[] {MAXNUMBERS};

                    }
                    // board[0][x][countClues] = (clues[countClues++] == 1)
                    //     ? new int[]{MAXNUMBERS, }
                    //     : Enumerable.Range(1, MAXNUMBERS - clues[countClues] + 1).ToArray();
                }

            }

            return new int[1][];


        }

        private static void MakeEmptyBoard(out int[][][] board, int[] clues)
        {
            board = new int[MaxY + 2][][];
            for (var y = 0; y < board[0].Length; y++)
            {
                for (var x = 0; x < board[0].Length; x++)
                {
                    // board[y]
                }

            }




            for (var y = 0; y < MaxY; y++)
            {
                board[y] = new int[MaxX][];
                // for (var x = 0; x < MaxX; x++)
                // {
                //     board[y][x] = new int[MAXNUMBERS];
                // }
            }




        }
        //
        // // todo    find edge 1 or 4 and fill
        //     // todo    mark rest of the edge, start from biger       on corner set lover list of numbers???
        //     // todo    mark rest and set if 1
        //     // todo    check if one left and set
        //     // todo    while(solve)
        //     // todo        check if max skyScraper can be placed and put it
        //     // todo        check if one left and set
        //     // todo        check if sets excluded 12 and 12 and 123 than there where is 123 set 3
        //     // todo        if necessary than set example 1 -> 4 (1,2,3)(1,2)(1,2,3) <- 2 than 4 (..)(..) 3
        //     // todo        if necessary than set example 3 -> (12)(12) 3 4 <- 1 than 2 1 3 4
        //     // todo        remove impossible from temp sets  1 -> 4 (123) (123) (12) <- 3  than 4 (123) (13) (12)
        //     // todo                             next inter   1 -> 4 (123) (13) (12)  <- 3 than
        //
        //
        //     // todo        check if there are for example row with edge 2 -> (12)(12) 4 3 <- 2 then resolve 2 1 4 3
        //     // todo        mark rest and if only one then set
        //
        //
        //     // todo        check and if yes set resolve numbers <---
        //     // todo        check and if yes set excluded
        //
        //
        //
        //
        //
        //
        // public static void RotateRight(IList sequence, int count)
        // {
        //     object tmp = sequence[count-1];
        //     sequence.RemoveAt(count - 1);
        //     sequence.Insert(0, tmp);
        // }
        //
        // public static IEnumerable<IList> Permutate(IList sequence, int count)
        // {
        //     if (count == 1) yield return sequence;
        //     else
        //     {
        //         for (int i = 0; i < count; i++)
        //         {
        //             foreach (var perm in Permutate(sequence, count - 1))
        //                 yield return perm;
        //             RotateRight(sequence, count);
        //         }
        //     }
        // }
    }
}