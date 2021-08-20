package unflatten_a_list_easy.kyu7;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class KataTest {
	@Test
	public void basicTests() {

		int[] input = new int[] { 3, 5, 2, 1 };
		Object[] expected = new Object[] { new int[] { 3,5,2 }, 1 };
		assertEquals(expected, Kata.unflatten(input));

		input = new int[] { 1, 4, 5, 2, 1, 2, 4, 5, 2, 6, 2, 3, 3 };
		expected = new Object[] { 1, new int[] { 4,5,2,1 }, 2, new int[] { 4,5,2,6 }, 2, new int[] { 3, 3 } };
		assertEquals(expected, Kata.unflatten(input));
	}
}