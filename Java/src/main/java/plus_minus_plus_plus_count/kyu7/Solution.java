package plus_minus_plus_plus_count.kyu7;

public class Solution {

	public static int signChange(int[] arr) {
		if (arr == null || arr.length == 0) {
			return 0;
		}
		var answer = 0;
		var sign = arr[0] >= 0;
		for (var i = 1; i < arr.length; i++) {
			if (sign != arr[i] >= 0) {
				answer++;
				sign = !sign;
			}
		}
		return answer;
	}
}
