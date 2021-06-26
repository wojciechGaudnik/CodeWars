package the_first_non_repeated_character_in_a_string.kyu7;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class FirstNonRepeatedTest {
	@Test
	public void test1() {
		final String input = "test";
		final Character output = FirstNonRepeated.firstNonRepeated(input);
		final Character expected = 'e';
		assertEquals(expected, output);
	}

	@Test
	public void test2() {
		final String input = "teeter";
		final Character output = FirstNonRepeated.firstNonRepeated(input);
		final Character expected = 'r';
		assertEquals(expected, output);
	}

	@Test
	public void test3() {
		final String input = "1122321235121222";
		final Character output = FirstNonRepeated.firstNonRepeated(input);
		final Character expected = '5';
		assertEquals(expected, output);
	}
}