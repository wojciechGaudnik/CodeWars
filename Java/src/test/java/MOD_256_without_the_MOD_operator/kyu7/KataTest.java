package MOD_256_without_the_MOD_operator.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class KataTest {
	@Test
	public void basicTests() {
		assertEquals(254, Kata.mod256WithoutMod(254));
		assertEquals(0, Kata.mod256WithoutMod(256));
		assertEquals(2, Kata.mod256WithoutMod(258));

		assertEquals(-254, Kata.mod256WithoutMod(-254));
		assertEquals(0, Kata.mod256WithoutMod(-256));
		assertEquals(-2, Kata.mod256WithoutMod(-258));
	}
}