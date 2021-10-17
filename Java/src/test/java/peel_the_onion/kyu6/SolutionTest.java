package peel_the_onion.kyu6;

import org.junit.Test;

import static org.junit.Assert.assertArrayEquals;
public class SolutionTest {
	@Test
	public void basicTests() {
		int[][][] expected = new int[][][]{{{1}, {2}, {2, 1}, {2, 2}, {2, 2, 1}},
				{{1}, {4}, {8, 1}, {12, 4}, {16, 8, 1}},
				{{1}, {8}, {26, 1}, {56, 8}, {98, 26, 1}},
				{{1}, {16}, {80, 1}, {240, 16}, {544, 80, 1}}};
		for (int d = 1; d < 5; d++) {
			for (int s = 1; s < 6; s++) {
				assertArrayEquals(expected[d - 1][s - 1], Solution.peelTheOnion(s, d));
			}
		}
	}
}