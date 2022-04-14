package sum_of_array_singles.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class SolutionTest {
	@Test
	public void basicTests() {
		assertEquals(15, Solution.repeats(new int[]{4, 5, 7, 5, 4, 8}));
		assertEquals(19, Solution.repeats(new int[]{9, 10, 19, 13, 19, 13}));
		assertEquals(12, Solution.repeats(new int[]{16, 0, 11, 4, 8, 16, 0, 11}));
	}
}