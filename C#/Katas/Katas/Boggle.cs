using System.Collections.Generic;

namespace Katas
{
    public class Boggle
    {
        private char[][] board;
        private string word;
        private int max;

        private List<int[]> around = new List<int[]>
        {
            new int[] {-1, -1},
            new int[] {-1, 0},
            new int[] {-1, 1},
            new int[] {0, -1},
            new int[] {0, 1},
            new int[] {1, -1},
            new int[] {1, 0},
            new int[] {1, 1},
        };

        public Boggle(char[][] board, string word)
        {
            this.board = board;
            this.word = word;
            this.max = board.Length;
        }

        public bool Check()
        {
            for (var y = 0; y < max; y++)
            {
                for (var x = 0; x < max; x++)
                {
                    if (board[y][x] != word[0]) continue;
                    var lastChar = board[y][x];
                    board[y][x] = '-';
                    if (FindDFS(board, word, y, x, 1)) return true;
                    board[y][x] = lastChar;
                }
            }

            return false;
        }

        private bool FindDFS(char[][] board, string word, int Y, int X, int charAt)
        {
            if (charAt == word.Length) return true;
            foreach (var coords in around)
            {
                if (Y + coords[0] < 0 ||
                    Y + coords[0] >= max ||
                    X + coords[1] < 0 ||
                    X + coords[1] >= max) continue;
                if (board[Y + coords[0]][X + coords[1]] != word[charAt]) continue;

                var lastChar = board[Y + coords[0]][X + coords[1]];
                board[Y + coords[0]][X + coords[1]] = '-';
                if (FindDFS(board, word, Y + coords[0], X + coords[1], charAt + 1)) return true;
                board[Y + coords[0]][X + coords[1]] = lastChar;
            }
            return false;
        }
    }
}