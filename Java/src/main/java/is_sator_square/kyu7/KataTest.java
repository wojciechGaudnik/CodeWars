package is_sator_square.kyu7;

import org.junit.jupiter.api.Disabled;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class KataTest {
	@Test
	void test3x3() {
		assertEquals(true, Kata.isSatorSquare(
				new char[][]{{'P', 'E', 'R'},
						{'E', 'V', 'E'},
						{'R', 'E', 'P'}}));
	}

	@Test
	void test3x3_1() {
		assertEquals(false, Kata.isSatorSquare(
				new char[][]{{'E', 'V', 'E'},
						{'E', 'E', 'E'},
						{'E', 'E', 'E'}}));
	}

	@Test
	void test4x4() {
		assertEquals(false, Kata.isSatorSquare(new char[][]{{'K', 'N', 'I', 'T'},          // warning:
				{'N', 'O', 'R', 'I'},          // O and 0 look similar
				{'I', 'R', '0', 'N'},          // but are not the same
				{'T', 'I', 'N', 'K'}}));
	}

	@Test
	void test4x4_1() {
		assertEquals(false, Kata.isSatorSquare(
				new char[][]{{'B', 'A', 'T', 'S'},          // warning:
						{'Ä', 'B', 'U', 'T'},          // O and 0 look similar
						{'T', 'U', 'B', 'Ä'},          // but are not the same
						{'S', 'T', 'A', 'B'}}));
	}

	@Test
	void test4x4_2() {
		assertEquals(false, Kata.isSatorSquare(
				new char[][]{{'(', '@', 'r', 'p'},          // warning:
						{'@', '\'', 'U', '|'},          // O and 0 look similar
						{'r', 'U', '\'', '@'},          // but are not the same
						{'p', '|', '@', '('}}));
	}

	@Test
	void test5x5() {
		assertEquals(true, Kata.isSatorSquare(
				new char[][]{{'S', 'A', 'T', 'O', 'R'},
						{'A', 'R', 'E', 'P', 'O'},
						{'T', 'E', 'N', 'E', 'T'},
						{'O', 'P', 'E', 'R', 'A'},
						{'R', 'O', 'T', 'A', 'S'}}));
	}
}