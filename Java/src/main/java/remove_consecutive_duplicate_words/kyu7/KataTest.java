package remove_consecutive_duplicate_words.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class KataTest {

	String s1 = "alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta";
	String ans1 = "alpha beta gamma delta alpha beta gamma delta";
	String s2 = "cyqje cyqje cyqje a a a";
	String ans2 = "cyqje a";

	@Test
	void basicTest() {
		assertEquals(ans1, Kata.removeConsecutiveDuplicates(s1), "For input \"" + s1 + "\"");
		assertEquals(ans2, Kata.removeConsecutiveDuplicates(s2), "For input \"" + s2 + "\"");
		assertEquals("", Kata.removeConsecutiveDuplicates(""), "For input \"" + "" + "\"");
		assertEquals("word", Kata.removeConsecutiveDuplicates("word"), "For input \"" + "word" + "\"");
		assertEquals("a ab", Kata.removeConsecutiveDuplicates("a a ab"), "For input \"" + "a a ab" + "\"");
	}

}
