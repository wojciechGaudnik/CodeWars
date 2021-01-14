package oRing_arrays.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertArrayEquals;

class OrArraysTest {
	@Test
	public void example1() {
		assertArrayEquals(new int[]{1, 2, 3},
				OrArrays.orArrays(new int[]{1, 2, 3}, new int[]{1, 2, 3}));
	}

	@Test
	public void example2() {
		assertArrayEquals(new int[]{5, 7, 7},
				OrArrays.orArrays(new int[]{1, 2, 3}, new int[]{4, 5, 6}));
	}

	@Test
	public void example3() {
		assertArrayEquals(new int[]{1, 2, 3},
				OrArrays.orArrays(new int[]{1, 2, 3}, new int[]{1, 2}));
	}

	@Test
	public void example4() {
		assertArrayEquals(new int[]{1, 2, 3}, OrArrays.orArrays(new int[]{1, 0}, new int[]{1, 2, 3}));
	}

	@Test
	public void example5() {
		assertArrayEquals(new int[]{1, 2, 3}, OrArrays.orArrays(new int[]{1, 0, 3}, new int[]{1, 2, 3}, 3));
	}
}