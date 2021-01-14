package greet_me.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class GreetMeTest {
	@Test
	public void basicTests() {
		assertEquals("Hello Riley!", GreetMe.greet("riley"));
	}
}