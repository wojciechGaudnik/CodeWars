package corner_fill.ku6;

import org.junit.jupiter.api.DisplayName;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertArrayEquals;

public class SolutionTest {
	@Test
	@DisplayName("Sample tests")
	public void test() {
		assertArrayEquals(new int[]{1}, Solution.cornerFill(new int[][]{{1}}));
		assertArrayEquals(new int[]{1, 2, 5, 4}, Solution.cornerFill(new int[][]{{1, 2}, {4, 5}}));
		assertArrayEquals(new int[]{1, 2, 3, 6, 9, 8, 5, 4, 7}, Solution.cornerFill(new int[][]{{1, 2, 3}, {4, 5, 6}, {7, 8, 9}}));
	}
}