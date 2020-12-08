package maximum_triplet_sum_array_series7.kyu7;

import java.util.Arrays;

public class Solution {

	public static int maxTriSum (int[] numbers)	{
		return  Arrays.stream(numbers)
				.boxed()
				.distinct()
				.sorted((a, b) -> Integer.compare(b, a))
				.limit(3)
				.mapToInt(Integer::intValue)
				.sum();
	}

}
