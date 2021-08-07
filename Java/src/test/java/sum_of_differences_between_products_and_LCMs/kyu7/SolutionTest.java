package sum_of_differences_between_products_and_LCMs.kyu7;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class SolutionTest {
	@Test
	public void BasicTests() {
		assertEquals(840, Solution.sumDifferencesBetweenProductsAndLCMs(new int[][]{{15, 18}, {4, 5}, {12, 60}}));
		assertEquals(1092, Solution.sumDifferencesBetweenProductsAndLCMs(new int[][]{{1, 1}, {0, 0}, {13, 91}}));
		assertEquals(0, Solution.sumDifferencesBetweenProductsAndLCMs(new int[][]{{15, 7}, {4, 5}, {19, 60}}));
		assertEquals(1890, Solution.sumDifferencesBetweenProductsAndLCMs(new int[][]{{20, 50}, {10, 10}, {50, 20}}));
		assertEquals(0, Solution.sumDifferencesBetweenProductsAndLCMs(new int[][]{}));
		assertEquals(571192496, Solution.sumDifferencesBetweenProductsAndLCMs(
				new int[][]{{130321, 122825}, {6137, 93347}, {175, 637}, {18, 14161}, {425, 6591}, {19652, 4225}, {93347, 189}}));
		assertEquals(-941443727, Solution.sumDifferencesBetweenProductsAndLCMs(new int[][]{{9025, 37349}, {88, 614125}, {274625, 171}, {1444, 171475}, {54872, 614125}, {3211, 5324}, {49, 122825}, {44217, 274625}, {361, 171}, {8575, 857375}}));
	}
}

