package regexp_basics_is_it_a_letter.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertFalse;
import static org.junit.jupiter.api.Assertions.assertTrue;

class StringUtilsTest {

	@Test
	public void fixedTests() {
		assertFalse(StringUtils.isLetter(""));
		assertTrue(StringUtils.isLetter("a"));
		assertTrue(StringUtils.isLetter("X"));
		assertFalse(StringUtils.isLetter("7"));
		assertFalse(StringUtils.isLetter("*"));
		assertFalse(StringUtils.isLetter("ab"));
		assertFalse(StringUtils.isLetter("a\n"));
	}
}