package product_of_maximums_of_array_array_series.kyu7;

import java.util.Arrays;

public class Solution {

	public static long maxProduct(int[] numbers, int sub_size) {
		return Arrays.stream(numbers)
				.boxed()
				.sorted((a, b) -> b - a)
				.mapToLong(Integer::longValue)
				.boxed()
				.limit(sub_size)
				.reduce(1L, (a, b) -> a * b);
	}
}
