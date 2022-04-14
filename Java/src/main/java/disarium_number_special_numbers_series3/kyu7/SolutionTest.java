package disarium_number_special_numbers_series3.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.Assert.assertEquals;

class SolutionTest {
	@Test
	public void Disarium_Or_NOT() {
		assertEquals("Disarium !!", Solution.disariumNumber(89));
		assertEquals("Not !!", Solution.disariumNumber(564));
		assertEquals("Not !!", Solution.disariumNumber(1024));
	}

	@Test
	public void Larger_Numbers() {
		assertEquals("Not !!", Solution.disariumNumber(64599));
		assertEquals("Not !!", Solution.disariumNumber(136586));
		assertEquals("Not !!", Solution.disariumNumber(1048576));
	}
}