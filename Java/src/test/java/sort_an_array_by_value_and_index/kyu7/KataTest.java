package sort_an_array_by_value_and_index.kyu7;

import org.junit.Test;

import java.util.Arrays;

import static org.junit.Assert.assertEquals;

public class KataTest {
	@Test
	public void exampleTests() {

		int[] actual = Kata.sortByValueAndIndex(new int[] { 1, 2, 3, 4, 5 });
		int[] expected = new int[] { 1, 2, 3, 4, 5 };
		String message = "Your result:\n" + arrayToString(actual) + "\n\nExpected result:\n" + arrayToString(expected) + "\n\n";
		assertEquals(message, arrayToString(expected), arrayToString(actual));

		actual = Kata.sortByValueAndIndex(new int[] { 23, 2, 3, 4, 5 });
		expected = new int[] { 2, 3, 4, 23, 5 };
		message = "Your result:\n" + arrayToString(actual) + "\n\nExpected result:\n" + arrayToString(expected) + "\n\n";
		assertEquals(message, arrayToString(expected), arrayToString(actual));

		actual = Kata.sortByValueAndIndex(new int[] { 26, 2, 3, 4, 5 });
		expected = new int[] { 2, 3, 4, 5, 26 };
		message = "Your result:\n" + arrayToString(actual) + "\n\nExpected result:\n" + arrayToString(expected) + "\n\n";
		assertEquals(message, arrayToString(expected), arrayToString(actual));

		actual = Kata.sortByValueAndIndex(new int[] { 9, 5, 1, 4, 3 });
		expected = new int[] { 1, 9, 5, 3, 4 };
		message = "Your result:\n" + arrayToString(actual) + "\n\nExpected result:\n" + arrayToString(expected) + "\n\n";
		assertEquals(message, arrayToString(expected), arrayToString(actual));
	}

	private String arrayToString(int[] array)
	{
		return Arrays.toString(array);
	}
}