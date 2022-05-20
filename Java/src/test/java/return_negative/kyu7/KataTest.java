package return_negative.kyu7;


import org.junit.jupiter.api.Test;

import static org.junit.Assert.assertEquals;

class MakeNegativeTest {

	@Test
	public void test1() {
		assertEquals(-42, Kata.makeNegative(42));
	}
}