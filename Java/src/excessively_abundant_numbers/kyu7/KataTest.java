package excessively_abundant_numbers.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;


class KataTest {
	@Test
	public void testAbundant() {
		assertEquals(true, Kata.abundantNumber(12));
		assertEquals(true, Kata.abundantNumber(18));
	}

	@Test
	public void testNonAbundant() {
		assertEquals(false, Kata.abundantNumber(37));
		assertEquals(false, Kata.abundantNumber(77));
	}
}