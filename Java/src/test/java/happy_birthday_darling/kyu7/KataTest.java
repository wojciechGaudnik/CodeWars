package happy_birthday_darling.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.Assert.assertEquals;

class KataTest {
	@Test
	public void basicTests() {
		assertEquals("32? That's just 20, in base 16!", Kata.womensAge(32));
		assertEquals("39? That's just 21, in base 19!", Kata.womensAge(39));
		assertEquals("22? That's just 20, in base 11!", Kata.womensAge(22));
		assertEquals("65? That's just 21, in base 32!", Kata.womensAge(65));
		assertEquals("83? That's just 21, in base 41!", Kata.womensAge(83));
	}
}