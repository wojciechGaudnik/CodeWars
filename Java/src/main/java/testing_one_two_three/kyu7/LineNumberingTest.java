package testing_one_two_three.kyu7;

import org.junit.jupiter.api.Test;

import java.util.Arrays;

import static org.junit.jupiter.api.Assertions.assertEquals;

class LineNumberingTest {
	@Test
	public void basicTests() {
		assertEquals(Arrays.asList(), LineNumbering.number(Arrays.asList()));
		assertEquals(Arrays.asList("1: a", "2: b", "3: c"), LineNumbering.number(Arrays.asList("a", "b", "c")));
		assertEquals(Arrays.asList("1: ", "2: ", "3: ", "4: ", "5: "), LineNumbering.number(Arrays.asList("", "", "", "", "")));
	}
}