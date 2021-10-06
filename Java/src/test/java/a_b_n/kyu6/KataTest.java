package a_b_n.kyu6;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class KataTest {
	@Test
	void testSomething() {
		assertEquals("1", Kata.formula(0));
		assertEquals("a+b", Kata.formula(1));
		assertEquals("a^2+2ab+b^2", Kata.formula(2));
		assertEquals("a^3+3a^2b+3ab^2+b^3", Kata.formula(3));
		assertEquals("a^5+5a^4b+10a^3b^2+10a^2b^3+5ab^4+b^5", Kata.formula(5));
		assertEquals("1/(a+b)", Kata.formula(-1));
		assertEquals("1/(a^2+2ab+b^2)", Kata.formula(-2));
		assertEquals("1/(a^4+4a^3b+6a^2b^2+4ab^3+b^4)", Kata.formula(-4));
	}
}