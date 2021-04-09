package tic_tac_toe_like_table_generator.kyu6;

public class Kata {

	static public String displayBoard(final char[] board, int width) {
		var answer = new StringBuilder();
		var line = new StringBuilder();
		var j = 0;
		while (j < board.length) {
			for (int i = 0 ; i < width; i++, j++) {
				line.append(" ").append(board[j]).append(" |");
			}
			line.replace(line.length() - 2, line.length(), " ");
			answer.append(line);
			if (j < board.length) {
				answer.append("\n").append("-".repeat(line.length())).append("\n");
			}
			line = new StringBuilder();
		}
		return answer.toString();
	}
}
