package grasshopper_debug.kyu8;

import org.junit.Test;

import static org.junit.jupiter.api.Assertions.*;

public class KataTest {
	@Test
	public void tests() {
		assertEquals("ttlheoiscstk", Kata.tripleTrouble("this", "test", "lock"));
		assertEquals("abcabc", Kata.tripleTrouble("aa", "bb", "cc"));
		assertEquals("Batman", Kata.tripleTrouble("Bm", "aa", "tn"));
		assertEquals("LexLuthor", Kata.tripleTrouble("LLh", "euo", "xtr"));
	}
}