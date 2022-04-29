package scrolling_text.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertArrayEquals;

class KataTest {

	@Test
	void basicTest() {
		String[] a1 = new String[]{"CODEWARS", "ODEWARSC", "DEWARSCO", "EWARSCOD", "WARSCODE", "ARSCODEW", "RSCODEWA", "SCODEWAR"};
		String[] a2 = new String[]{"HELLO", "ELLOH", "LLOHE", "LOHEL", "OHELL"};
		String[] a3 = new String[]{"GOOD LUCK!", "OOD LUCK!G", "OD LUCK!GO", "D LUCK!GOO", " LUCK!GOOD", "LUCK!GOOD ", "UCK!GOOD L",
				"CK!GOOD LU", "K!GOOD LUC", "!GOOD LUCK"};

		assertArrayEquals(a1, Kata.scrollingText("codewars"), "For input \"codewars\"");
		assertArrayEquals(a2, Kata.scrollingText("hello"), "For input \"hello\"");
		assertArrayEquals(a3, Kata.scrollingText("good luck!"), "For input \"good luck!\"");

	}
}