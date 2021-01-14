package find_count_of_most_frequent_item_in_an_array.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class KataTest {

	@Test
	public void tests() {
		assertEquals(2, Kata.mostFrequentItemCount(new int[] {3, -1, -1}));
		assertEquals(5, Kata.mostFrequentItemCount(new int[] {3, -1, -1, -1, 2, 3, -1, 3, -1, 2, 4, 9, 3}));
	}
}