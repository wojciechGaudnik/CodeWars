package reverse_the_bits_in_an_integer.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class BitsOfIntegerTest {
	@Test
	public void fixed_tests() {
		assertEquals(BitsOfInteger.reverse_bits(417), 267);
		assertEquals(BitsOfInteger.reverse_bits(267), 417);
		assertEquals(BitsOfInteger.reverse_bits(0), 0);
		assertEquals(BitsOfInteger.reverse_bits(2017), 1087);
		assertEquals(BitsOfInteger.reverse_bits(1023), 1023);
		assertEquals(BitsOfInteger.reverse_bits(1024), 1);
	}
}