using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Katas
{
    public class ConnectFour
    {
        public static string WhoIsWinner(List<string> piecesPositionList)
        {
            var board = new int[6][];
            for (var y = 0; y < 6; y++)
            {
                board[y] = new int[7];
            }

            foreach (var move in piecesPositionList)
            {
                var whole = new StringBuilder();
                var moveSpited = move.Split("_");
                var xPlayer = char.Parse(moveSpited[0]) - 'A';
                var player = (moveSpited[1] == "Red") ? 2: 1;

                for (var y = 5; y >= 0; y--)
                {
                    if (board[y][xPlayer] != 0) continue;
                    board[y][xPlayer] = player; break;
                }

                for(var y = 5; y >= 0; y--)
                {
                    whole.AppendJoin("", board[y]);
                    whole.Append("|");
                }
                for(var x = 0; x < 7; x++)
                {
                    for (var y = 0; y < 6; y++) whole.Append(board[y][x]);
                    whole.Append("|");
                }
                for (var Y = 2; Y >= 0 ; Y--)
                {
                    for (int y = Y, x = 0; y < 6; y++, x++) whole.AppendJoin("", board[y][x]);
                    whole.Append("|");
                }
                for (var X = 1; X < 4; X++)
                {
                    for (int y = 0, x = X; x < 7; y++, x++) whole.AppendJoin("", board[y][x]);
                    whole.Append("|");
                }
                for (var Y = 2; Y >= 0 ; Y--)
                {
                    for (int y = Y, x = 6; y < 6; y++, x--) whole.AppendJoin("", board[y][x]);
                    whole.Append("|");
                }
                for (var X = 5; X > 2; X--)
                {
                    for (int y = 0, x = X; x >= 0; y++, x--) whole.AppendJoin("", board[y][x]);
                    whole.Append("|");
                }
                if (Regex.IsMatch(whole.ToString(), "(1){4}")) return "Yellow";
                if (Regex.IsMatch(whole.ToString(), "(2){4}")) return "Red";
            }
            return "Draw";
        }
    }
}