package guess_the_sequence.kyu7;

import org.junit.Test;

import java.util.Arrays;

import static org.junit.Assert.assertEquals;
// TODO: Replace examples and use TDD development by writing your own tests

public class JomoPipiTest {
	@Test
	public void test0() {
		int[] result = {1, 10, 11, 12, 13, 14, 15, 16, 2, 3, 4, 5, 6, 7, 8, 9};
		int x = 17;
		String expected = Arrays.toString(result),
				actual = Arrays.toString(JomoPipi.sequence(x));
		assertEquals(expected, actual);
	}

	@Test
	public void test1() {
		int[] result = {1, 2, 3, 4, 5, 6, 7, 8, 9};
		int x = 9;
		String expected = Arrays.toString(result),
				actual = Arrays.toString(JomoPipi.sequence(x));
		assertEquals(expected, actual);
	}
}