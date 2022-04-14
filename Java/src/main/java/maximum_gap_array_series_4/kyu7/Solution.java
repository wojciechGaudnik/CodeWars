package maximum_gap_array_series_4.kyu7;

import java.util.Arrays;
import java.util.stream.Collectors;

public class Solution {

	public static int maxGap(int[] numbers) {
		var sortedNumbers = Arrays.stream(numbers).sorted().boxed().collect(Collectors.toList());
		var min = Integer.MIN_VALUE;
		for (var i = 0; i < sortedNumbers.size() - 1; i++) {
			var diff = sortedNumbers.get(i + 1) - sortedNumbers.get(i);
			if (diff > min) min = diff;
		}
		return min;
	}
}
   
