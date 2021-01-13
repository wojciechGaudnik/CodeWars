package coloured_triangles.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class KataTest {

	@Test
	public void examples() {
		// assertEquals("expected", "actual");
		assertEquals('R', Kata.triangle("GB"));
		assertEquals('R', Kata.triangle("RRR"));
		assertEquals('B', Kata.triangle("RGBG"));
		assertEquals('G', Kata.triangle("RBRGBRB"));
		assertEquals('G', Kata.triangle("RBRGBRBGGRRRBGBBBGG"));
		assertEquals('B', Kata.triangle("B"));
	}
}