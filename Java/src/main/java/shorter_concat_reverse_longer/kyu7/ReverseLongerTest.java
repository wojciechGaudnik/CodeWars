package shorter_concat_reverse_longer.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class ReverseLongerTest {

	@Test
	public void static1() {
		assertEquals("abcdetsrifabcde", ReverseLonger.shorterReverseLonger("first", "abcde"));
		assertEquals("bauollehbau", ReverseLonger.shorterReverseLonger("hello", "bau"));
		assertEquals("fghiedcbafghi", ReverseLonger.shorterReverseLonger("abcde", "fghi"));
	}

}