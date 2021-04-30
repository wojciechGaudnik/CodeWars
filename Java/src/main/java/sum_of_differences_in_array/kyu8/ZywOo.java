package sum_of_differences_in_array.kyu8;

import java.util.Arrays;

public class ZywOo {
	public static int sumOfDifferences(int[] arr) {
		if (arr.length <= 1) {
			return 0;
		}
		var answer = 0;
		Arrays.sort(arr);
		for (var i = arr.length - 1; i > 0; i--) {
			answer += arr[i] - arr[i - 1];
		}
		return answer;
	}
}
