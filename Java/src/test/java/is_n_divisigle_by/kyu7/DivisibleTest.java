package is_n_divisigle_by.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class DivisibleTest {
	@Test
	public void basicTests() throws Exception {
		assertEquals(Divisible.isDivisible(3, 3, 4), false);
		assertEquals(Divisible.isDivisible(12, 3, 4), true);
		assertEquals(Divisible.isDivisible(8, 3, 4, 2, 5), false);
	}
}