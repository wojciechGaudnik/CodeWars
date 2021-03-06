package count_the_characters.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class CCTest {
	@Test
	public void testSomething() {
		assertEquals(4, CC.charCount("fizzbuzz", 'z'));
		assertEquals(4, CC.charCount("FIZZBUZZ", 'z'));
	}
}