package counting_power_sets.kyu7;


import org.junit.jupiter.api.Test;

import java.math.BigInteger;

import static org.junit.Assert.assertEquals;

class PowersTest {

	@Test
	public void testPactical() {
//		assertEquals("An empty array should return 1!", Powers.powers(new int[]{}), BigInteger.valueOf(1));
		assertEquals(Powers.powers(new int[]{1}), BigInteger.valueOf(2));
		assertEquals(Powers.powers(new int[]{1,2,3,4,5}), BigInteger.valueOf(32));
	}
}