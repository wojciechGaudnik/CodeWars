package ieee_754_floating_point_numbers.kyu6;

import org.junit.Test;

import static org.junit.Assert.assertEquals;
public class SolutionTest {
	@Test
	public void sampleTestsDouble() {
		assertEquals("0 10000000010 1111110000000000000000000000000000000000000000000000", Solution.doubleToIEEE_754(15.875));
		assertEquals("1 01111111111 0000000000000000000000000000000000000000000000000000", Solution.doubleToIEEE_754(-1.0));
	}

	@Test
	public void testSpecialValuesDouble() {
		assertEquals("0 11111111111 1000000000000000000000000000000000000000000000000000", Solution.doubleToIEEE_754(+ Double.NaN));
		assertEquals("0 11111111111 0000000000000000000000000000000000000000000000000000", Solution.doubleToIEEE_754(Double.POSITIVE_INFINITY));
		assertEquals("1 11111111111 0000000000000000000000000000000000000000000000000000", Solution.doubleToIEEE_754(Double.NEGATIVE_INFINITY));
		assertEquals("0 00000000000 0000000000000000000000000000000000000000000000000000", Solution.doubleToIEEE_754(+ 0.0));
		assertEquals("1 00000000000 0000000000000000000000000000000000000000000000000000", Solution.doubleToIEEE_754(- 0.0));
		assertEquals("0 11111111110 1111111111111111111111111111111111111111111111111111", Solution.doubleToIEEE_754(+ Double.MAX_VALUE));
		assertEquals("1 11111111110 1111111111111111111111111111111111111111111111111111", Solution.doubleToIEEE_754( -Double.MAX_VALUE));
		assertEquals("0 00000000000 0000000000000000000000000000000000000000000000000001", Solution.doubleToIEEE_754(+ Double.MIN_VALUE));
		assertEquals("1 00000000000 0000000000000000000000000000000000000000000000000001", Solution.doubleToIEEE_754(- Double.MIN_VALUE));
	}
	@Test
	public void sampleTestsFLoat() {
		assertEquals("0 10000010 11111100000000000000000", Solution.floatToIEEE_754(15.875f));
		assertEquals("1 01111111 00000000000000000000000", Solution.floatToIEEE_754(-1.0f));
	}

	@Test
	public void testSpecialValuesFloat() {
		assertEquals("0 11111111 10000000000000000000000", Solution.floatToIEEE_754(Float.NaN));
		assertEquals("0 11111111 00000000000000000000000", Solution.floatToIEEE_754(Float.POSITIVE_INFINITY));
		assertEquals("1 11111111 00000000000000000000000", Solution.floatToIEEE_754(Float.NEGATIVE_INFINITY));
		assertEquals("0 00000000 00000000000000000000000", Solution.floatToIEEE_754(+ 0.0f));
		assertEquals("1 00000000 00000000000000000000000", Solution.floatToIEEE_754(- 0.0f));
		assertEquals("0 11111110 11111111111111111111111", Solution.floatToIEEE_754(+ Float.MAX_VALUE));
		assertEquals("1 11111110 11111111111111111111111", Solution.floatToIEEE_754(- Float.MAX_VALUE));
		assertEquals("0 00000000 00000000000000000000001", Solution.floatToIEEE_754(+ Float.MIN_VALUE));
		assertEquals("1 00000000 00000000000000000000001", Solution.floatToIEEE_754(- Float.MIN_VALUE));
	}
}