package number_of_decimal_digits.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class DecToolsTest {

	@Test
	public void Digits() {
		assertEquals(1, DecTools.Digits(5l));
		assertEquals(5, DecTools.Digits(12345l));
		assertEquals(10, DecTools.Digits(9876543210l));
	}
}