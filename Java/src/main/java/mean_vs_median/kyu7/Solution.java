package mean_vs_median.kyu7;

import java.util.Arrays;

public class Solution {
	public static String meanVsMedian(int[] numbers) {
		double mean = Arrays.stream(numbers).sum() / numbers.length;
		double median = 0;
		Arrays.sort(numbers);
		if (numbers.length % 2 == 0) {
			median = (numbers[numbers.length / 2] + numbers[(numbers.length / 2) + 1]) / 2.0;
		} else {
			median = numbers[(numbers.length / 2)];
		}
		return (mean == median) ? "same" : (mean > median) ? "mean" : "median";
	}
}
