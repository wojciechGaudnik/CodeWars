package halving_sum.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class HalvingSumTest {

	@Test
	public void test() {
		HalvingSum hs = new HalvingSum();
		assertEquals(47, hs.halvingSum(25));
		assertEquals(247, hs.halvingSum(127));
	}
}