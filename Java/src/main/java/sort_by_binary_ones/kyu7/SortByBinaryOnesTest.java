package sort_by_binary_ones.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;


public class SortByBinaryOnesTest {
	@Test
	public void testSort() {
		SortByBinaryOnes sortByBinary = new SortByBinaryOnes();
//		assertEquals(sortByBinary.sort(new Integer[]{1, 3}), new Integer[]{3, 1});
		assertEquals(sortByBinary.sort(new Integer[]{1, 2, 3, 4}), new Integer[]{3, 1, 2, 4});
	}
}
