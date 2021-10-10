package kingdoms_ep2_the_curse_simplified.kyu8;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class KataTest {
	@Test
	void sample() {
		assertEquals("hello world!", Kata.translate("***lo w***d!", new String[]{"hello", "world"}));
		assertEquals("cell, weak!", Kata.translate("c**l, w*ak!", new String[]{"hell", "cell", "week", "weak"}));
		assertEquals("hello, world!", Kata.translate("hell*, w***d!", new String[]{"hello", "hell", "word", "world"}));
		assertEquals("mel", Kata.translate("***", new String[]{"mel", "dell"}));
		assertEquals("", Kata.translate("", new String[]{"hell", "weak"}));
		assertEquals("bbbb. aaa,", Kata.translate("****. ***,", new String[]{"aaa", "bbbb"}));
	}

	@Test
	void newEdge() {
		String result = "qow qqqovq qpqq ooqqu oqqqy ptqqq. sqopq. qropoo, qpx";
		String sp = "*ow ****v* **** ****u oq**y *t***. s*opq. qro***, q*x";
		String[] voc = new String[]{"ooqqu", "ptqqq", "qqqovq", "qpqq", "qpx", "oqqqy", "qropoo", "sqopq", "qow"};
		assertEquals(result, Kata.translate(sp, voc));
	}
}