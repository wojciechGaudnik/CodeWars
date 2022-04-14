package Math;

import java.util.Arrays;

public class Math {

	public static int[] Interval(int[] arr, String str) {
		if (arr.length == 0 || str.length() == 0) {
			return new int[]{};
		}
		int[] numbers = Arrays.stream(str.substring(1, str.length() - 1).split(",\\s*")).mapToInt(Integer::parseInt).toArray();
		int leftInt = (str.charAt(0) == '(') ? numbers[0] : numbers[0] - 1;
		int rightInt = (str.charAt(str.length() - 1) == ')') ? numbers[1] : numbers[1] + 1;
		return Arrays.stream(arr).sorted().filter(e -> e > leftInt && e < rightInt).toArray();
	}
}
