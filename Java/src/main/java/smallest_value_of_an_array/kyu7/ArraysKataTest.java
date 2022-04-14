package smallest_value_of_an_array.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.Assert.assertEquals;

class ArraysKataTest {

	@Test
	public void testSample() {
		assertEquals("The smallest index", 0, ArraysKata.findSmallest(new int[]{1, 2, 3}, "index"));
		assertEquals("The smallest value", 2, ArraysKata.findSmallest(new int[]{7, 12, 3, 2, 27}, "value"));
		assertEquals("The smallest index", 3, ArraysKata.findSmallest(new int[]{7, 12, 3, 2, 27}, "index"));
	}
}