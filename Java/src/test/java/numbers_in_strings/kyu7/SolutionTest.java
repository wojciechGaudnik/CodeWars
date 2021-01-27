package numbers_in_strings.kyu7;

import count_all_the_sheep_on_farm_in_the_heights_of_new_zealand.kyu7.Kata;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class SolutionTest {
	@Test
	public void basicTests() {
		assertEquals(5, Kata.lostSheeps(new int[] {1,2}, new int[] {3,4}, 15));
		assertEquals(6, Kata.lostSheeps(new int[] {3,1,2}, new int[] {4,5}, 21));
	}
}