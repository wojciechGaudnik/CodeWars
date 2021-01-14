package how_many_consecutive_numbers_are_needed.kyu7;

import java.util.Arrays;

public class Kata {
	public static int consecutive(final int[] arr) {
		Arrays.sort(arr);
		var answer = 0;
		for (var i = 0; i < arr.length - 1; i++) {
			if (arr[i] + 1 != arr[i + 1]) {
				answer += arr[i + 1] - arr[i] - 1;
			}
		}
		return answer;
	}
}
