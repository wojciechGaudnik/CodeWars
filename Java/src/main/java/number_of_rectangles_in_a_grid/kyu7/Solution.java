package number_of_rectangles_in_a_grid.kyu7;

public class Solution {

	public static int numberOfRectangles(int m, int n) {
		return (m * n * (n + 1) * (m + 1)) / 4;
	}
}
