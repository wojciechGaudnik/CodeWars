package suitcase_packing.kyu7;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class MrSquereTest {
	@Test
	public void fixed_test() {
		assertEquals(true, MrSquare.fit_in(1, 2, 3, 2));
		assertEquals(false, MrSquare.fit_in(1, 2, 2, 1));
		assertEquals(false, MrSquare.fit_in(3, 2, 3, 2));
		assertEquals(false, MrSquare.fit_in(1, 2, 1, 2));
		assertEquals(false, MrSquare.fit_in(6, 5, 8, 7));
		assertEquals(false, MrSquare.fit_in(5, 2, 5, 6));
		assertEquals(false, MrSquare.fit_in(1, 2, 10, 1));
	}
}