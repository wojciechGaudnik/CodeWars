package atm.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class ATMTest {
	@Test
	public void testATM() {
		assertEquals(4, new ATM().solve(770));
		assertEquals(-1, new ATM().solve(125));
		assertEquals(2, new ATM().solve(550));
		assertEquals(1, new ATM().solve(10));
		assertEquals(-1, new ATM().solve(238));
	}

}