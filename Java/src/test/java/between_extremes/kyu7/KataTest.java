package between_extremes.kyu7;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class KataTest {
	@Test
	public void fixedTest() {
		assertEquals(42, Kata.betweenExtremes(new int[]{21, 34, 54, 43, 26, 12}));
		assertEquals(99, Kata.betweenExtremes(new int[]{-1, -41, -77, -100}));
	}
}