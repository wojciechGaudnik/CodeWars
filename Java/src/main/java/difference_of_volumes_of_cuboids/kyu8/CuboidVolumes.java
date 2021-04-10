package difference_of_volumes_of_cuboids.kyu8;

import java.util.Arrays;

public class CuboidVolumes {
	public static int findDifference(final int[] firstCuboid, final int[] secondCuboid) {
		return Math.abs(Arrays.stream(firstCuboid).reduce(1, (a, b) -> a * b) - Arrays.stream(secondCuboid).reduce(1, (a, b) -> a * b));
	}
}
