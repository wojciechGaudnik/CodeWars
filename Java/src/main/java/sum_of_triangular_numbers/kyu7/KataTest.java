package sum_of_triangular_numbers.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class KataTest {
	@Test
	public void basicTests() {
		assertEquals(56, Kata.sumTriangularNumbers(6));
		assertEquals(7140, Kata.sumTriangularNumbers(34));
		assertEquals(0, Kata.sumTriangularNumbers(-291));
		assertEquals(140205240, Kata.sumTriangularNumbers(943));
		assertEquals(0, Kata.sumTriangularNumbers(-971));
	}

}