package largest_pair_sum_in_array.kyu7;

import java.util.Arrays;

public class Solution {

	public static int largestPairSum(int[] numbers) {
		Arrays.sort(numbers);
		return numbers[numbers.length - 2] + numbers[numbers.length - 1];
	}

}
