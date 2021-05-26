package overflowing_with_longing.kyu7;

import org.junit.Test;
import static org.junit.Assert.assertEquals;

public class MultiplierTest {

	@Test
	public void test00() {
		assertEquals(0, Multiplier.multiply(0, 0));
	}

	@Test
	public void test2345() {
		assertEquals(1035, Multiplier.multiply(23, 45));
	}

	@Test
	public void test3456() {
		assertEquals(-1904, Multiplier.multiply(-34, 56));
	}

	@Test
	public void testMin() {
		assertEquals(Long.MIN_VALUE, Multiplier.multiply(-2147483648L, 4294967296L));
	}

	@Test
	public void testMax() {
		assertEquals(Long.MAX_VALUE, Multiplier.multiply(2323823089L, 3969050863L));
	}

	@Test(expected=ArithmeticException.class)
	public void testOverflowMax() {
		Multiplier.multiply(Long.MAX_VALUE, Long.MAX_VALUE);
	}

	@Test(expected=ArithmeticException.class)
	public void testOverflowMin() {
		Multiplier.multiply(Long.MIN_VALUE, Long.MIN_VALUE);
	}

	@Test(expected=ArithmeticException.class)
	public void testOverflowMaxMin() {
		Multiplier.multiply(Long.MAX_VALUE, Long.MIN_VALUE);
	}

	@Test(expected=ArithmeticException.class)
	public void testOverflow1() {
		Multiplier.multiply(119537721L, 77158673929L); // -> Long.MAX_VALUE + 2
	}

	@Test(expected=ArithmeticException.class)
	public void testOverflow2() {
		Multiplier.multiply(-2761311370L, 3340214413L); // -> Long.MIN_VALUE - 2
	}
}