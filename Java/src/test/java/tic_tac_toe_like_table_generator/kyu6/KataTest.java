package tic_tac_toe_like_table_generator.kyu6;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class KataTest {
	@Test
	public void basicTests() {
		doTest(new char[]{'O', 'X', 'X', 'O'}, 2, " O | X \n-------\n X | O ");
		doTest(new char[]{'O', 'X', ' ', ' ', 'X', ' ', 'X', 'O', ' '}, 3, " O | X |   \n-----------\n   | X |   \n-----------\n X | O |   ");
		doTest(new char[]{'O', 'X', ' ', ' ', 'X', ' ', 'X', 'O', ' ', 'O'}, 5, " O | X |   |   | X \n-------------------\n   | X | O |   | O ");
		doTest(new char[]{'O', 'X', ' ', ' ', 'X', ' ', 'X', 'O', ' ', 'O'}, 2, " O | X \n-------\n   |   \n-------\n X |   \n-------\n X | O \n-------\n   | O ");
		doTest(new char[]{'1', '2', '3', '4', '5', '1', '2', '3', '4', '5', '1', '2', '3', '4', '5', '1', '2', '3', '4', '5', '1', '2', '3', '4', '5', '1', '2', '3', '4', '5', '1', '2', '3', '4', '5', '1'}, 6, " 1 | 2 | 3 | 4 | 5 | 1 \n-----------------------\n 2 | 3 | 4 | 5 | 1 | 2 \n-----------------------\n 3 | 4 | 5 | 1 | 2 | 3 \n-----------------------\n 4 | 5 | 1 | 2 | 3 | 4 \n-----------------------\n 5 | 1 | 2 | 3 | 4 | 5 \n-----------------------\n 1 | 2 | 3 | 4 | 5 | 1 ");
	}
	private void doTest(final char[] board, final int width, final String expected) {
		assertEquals(expected, Kata.displayBoard(board, width));
	}
}