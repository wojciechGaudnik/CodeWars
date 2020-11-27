package nth_power_rules_them_all.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class KataTest {
	@Test
	public void basicTests() {
		assertEquals(30, Kata.modifiedSum(new int[] {1,2,3}, 3));
		assertEquals(30, Kata.modifiedSum(new int[] {1,2}, 5));
	}
}