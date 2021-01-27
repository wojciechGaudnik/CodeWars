package compare_strings_by_sum_of_chars.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class KataTest {
	@Test
	public void BasicTests() {
		assertEquals(true, Kata.compare("AD", "BC"));
		assertEquals(false, Kata.compare("AD", "DD"));
	}
}