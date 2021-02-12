package the_fusc_function_part_1.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class KataTest {
	@Test
	public void tests() {
		assertEquals(0, Kata.fusc(0));
		assertEquals(1, Kata.fusc(1));
		assertEquals(21, Kata.fusc(85));
	}
}