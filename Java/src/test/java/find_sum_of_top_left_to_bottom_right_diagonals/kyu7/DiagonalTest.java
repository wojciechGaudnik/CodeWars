package find_sum_of_top_left_to_bottom_right_diagonals.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class DiagonalTest {
	@Test
	public void testMatrix1() {
		final int[][] matrix = new int[][]{{12}};
		assertEquals(12, Diagonal.diagonalSum(matrix));
	}

	@Test
	public void testMatrix2() {
		final int[][] matrix = new int[][]{{1, 2}, {3, 4}};
		assertEquals(5, Diagonal.diagonalSum(matrix));
	}

	@Test
	public void testMatrix3() {
		final int[][] matrix = new int[][]{{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
		assertEquals(15, Diagonal.diagonalSum(matrix));
	}

	@Test
	public void testMatrix4() {
		final int[][] matrix = new int[][]{{1, 2, 3, 4}, {5, 6, 7, 8}, {9, 10, 11, 12}, {13, 14, 15, 16}};
		assertEquals(34, Diagonal.diagonalSum(matrix));
	}
}