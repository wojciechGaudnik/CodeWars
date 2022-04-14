package sort_arrays_minus_one.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class SortArrayTest {
	@Test
	public void intArrayTests() {
		int[] ai = {1, 2, 3};
		int[] uai = {2, 3, 1};
		assertEquals(ai[0], SortArray.sortArray(uai)[0]);
		assertEquals(ai[1], SortArray.sortArray(uai)[1]);
		assertEquals(ai[2], SortArray.sortArray(uai)[2]);
	}
}