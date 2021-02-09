package inspiring_strings.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class KataTest {
	@Test
	public void tests() {
		assertEquals("fgh", Kata.longestWord("a b c d e fgh"));
		assertEquals("three", Kata.longestWord("one two three"));
		assertEquals("grey", Kata.longestWord("red blue grey"));
	}
}