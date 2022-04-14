package lost_number_in_number_sequence.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class KataTest {

	@Test
	public void basicTests() {
		assertEquals(2, Kata.findDeletedNumber(new int[]{1, 2, 3, 4, 5}, new int[]{3, 4, 1, 5}));
		assertEquals(5, Kata.findDeletedNumber(new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9}, new int[]{1, 9, 7, 4, 6, 2, 3, 8}));
		assertEquals(0, Kata.findDeletedNumber(new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9}, new int[]{5, 7, 6, 9, 4, 8, 1, 2, 3}));
	}
}