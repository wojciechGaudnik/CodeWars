package alternate_case.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class KataTest {

	@Test
	public void testSomething() {
		assertEquals("", Kata.alternateCase(""));
		assertEquals("ABC", Kata.alternateCase("abc"));
		assertEquals("abc", Kata.alternateCase("ABC"));
		assertEquals("hELLO wORLD!", Kata.alternateCase("Hello World!"));
	}
}