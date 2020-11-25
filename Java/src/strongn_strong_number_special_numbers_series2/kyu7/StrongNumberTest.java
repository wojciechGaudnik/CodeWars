package strongn_strong_number_special_numbers_series2.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class StrongNumberTest {

	private static String STRONG = "STRONG!!!!";
	private static String NOT_STRONG = "Not Strong !!";

	@Test
	public void testSomething() {
		assertEquals(STRONG, StrongNumber.isStrongNumber(1));
		assertEquals(STRONG, StrongNumber.isStrongNumber(2));
		assertEquals(STRONG, StrongNumber.isStrongNumber(145));
		assertEquals(NOT_STRONG, StrongNumber.isStrongNumber(7));
		assertEquals(NOT_STRONG, StrongNumber.isStrongNumber(93));
		assertEquals(NOT_STRONG, StrongNumber.isStrongNumber(185));
		assertEquals(NOT_STRONG, StrongNumber.isStrongNumber(999999999));
		assertEquals(NOT_STRONG, StrongNumber.isStrongNumber(999999999));
		assertEquals(NOT_STRONG, StrongNumber.isStrongNumber(999999999));
		assertEquals(NOT_STRONG, StrongNumber.isStrongNumber(999999999));
		assertEquals(NOT_STRONG, StrongNumber.isStrongNumber(999999999));
		assertEquals(NOT_STRONG, StrongNumber.isStrongNumber(999999999));
	}

}