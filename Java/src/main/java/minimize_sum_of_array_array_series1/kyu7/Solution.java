package minimize_sum_of_array_array_series1.kyu7;

import java.util.Arrays;

public class Solution {

	public static int minSum(int[] passed){
		Arrays.sort(passed);
		var sum = 0;
		for (int i = 0, j = passed.length - 1; i < j; i++, j--) {
			sum += passed[i] * passed[j];
		}
		return sum;
	}
}
