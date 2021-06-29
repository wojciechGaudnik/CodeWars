package stanton_measure.kyu7;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class KataTest {
	@Test
	public void sampleTests() {
		assertEquals(3, Kata.stantonMeasure(new int[] {1, 4, 3, 2, 1, 2, 3, 2}));
		assertEquals(1, Kata.stantonMeasure(new int[] {5, -7, 1, 1, 2, 0, -12, -2, 10, 14, -13, 11, -13, 5, 1, 2, -10, 5, -6, 4, 1, -15, -5, 1, -2, 7, -3, 7, 5, 4, 9, 3, -12, 5, 4, 1, 14, 5, 13, 4, -11, -6, 6, 1, -4, -6, 19, 11, -6, 1, 3, 12, 1, 3, 1, 16, -5, -13, 1, -5, -11, 8, -5, -5, 11, 1, -19, 18, 7, -6, 12, -7, 13, 1, 16, 15, 11, 4, -4, 0, -9, -4, -3, -4, 10, 5, -12, 1, 18, -13, -18, 1, 12, -14, -8, -16, -6, 3, -1, 13}));
	}
}