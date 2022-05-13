package scrabble_score.kyu7;

import org.junit.jupiter.api.Test;
		import static org.junit.jupiter.api.Assertions.assertEquals;

class KataTest {
	@Test
	public void basicTest() {
		assertEquals(0, Kata.scrabbleScore(""), "For empty input");
		assertEquals(1, Kata.scrabbleScore("a"), "For input \"a\"");
		assertEquals(4, Kata.scrabbleScore("f"), "For input \"f\"");
		assertEquals(6, Kata.scrabbleScore("street"), "For input \"street\"");
		assertEquals(1, Kata.scrabbleScore(" a"), "For input \" a\"");
		assertEquals(6, Kata.scrabbleScore("st re et"), "For input \"st re et\"");
		assertEquals(22, Kata.scrabbleScore("quirky"), "For input \"quirky\"");
		assertEquals(20, Kata.scrabbleScore("MULTIBILLIONAIRE"), "For input \"MULTIBILLIONAIRE\"");
		assertEquals(13, Kata.scrabbleScore("alacrity"), "For input \"alacrity\"");
		assertEquals(6, Kata.scrabbleScore("STREET"), "For input \"STREET\"");
		assertEquals(64, Kata.scrabbleScore("xNZyYOzGZXoBUl"), "For input \"STREET\"");
	}
}
