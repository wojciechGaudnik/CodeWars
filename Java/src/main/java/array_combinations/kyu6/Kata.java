package array_combinations.kyu6;

import java.util.List;

public class Kata {
	public static int solve(final List<List<Integer>> data) {
		return data.stream().mapToInt(l -> (int) l.stream().distinct().count()).reduce(1, (a, b) -> a * b);
	}
}
