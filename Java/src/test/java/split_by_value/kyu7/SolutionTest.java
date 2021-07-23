package split_by_value.kyu7;

import org.junit.Test;

import java.util.Arrays;

import static org.junit.Assert.assertEquals;

public class SolutionTest {
	@Test
	public void testCase1() {
		Solution sol = new Solution();
		assertEquals(Arrays.toString(new int[] {1, 3, 4, 2, 5, 7, 6}),Arrays.toString(sol.splitByValue(5, new int[] {1, 3, 5, 7, 6, 4, 2})));
		assertEquals(Arrays.toString(new int[] {5, 2, 7, 3, 2}),Arrays.toString(sol.splitByValue(0, new int[] {5, 2, 7, 3, 2})));
		assertEquals(Arrays.toString(new int[] {4, 6, 10, 10, 6}), Arrays.toString(sol.splitByValue(6, new int[] {6, 4, 10, 10, 6})));
	}
}