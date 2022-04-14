package cartesian_neighbors.kyu7;

public class Kata {
	public static int[][] cartesianNeighbor(int x, int y) {
		return new int[][]{{x - 1, y - 1}, {x, y - 1}, {x + 1, y - 1}, {x - 1, y}, {x + 1, y}, {x - 1, y + 1}, {x, y + 1}, {x + 1, y + 1}};
	}
}
