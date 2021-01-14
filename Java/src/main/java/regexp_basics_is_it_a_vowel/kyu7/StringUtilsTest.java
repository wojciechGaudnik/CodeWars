package regexp_basics_is_it_a_vowel.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertFalse;
import static org.junit.jupiter.api.Assertions.assertTrue;

class StringUtilsTest {

	@Test
	public void fixedTests() {
		assertFalse(StringUtils.isVowel(""));
		assertTrue(StringUtils.isVowel("a"));
		assertTrue(StringUtils.isVowel("E"));
		assertFalse(StringUtils.isVowel("ou"));
		assertFalse(StringUtils.isVowel("z"));
		assertFalse(StringUtils.isVowel("lol"));
	}
}