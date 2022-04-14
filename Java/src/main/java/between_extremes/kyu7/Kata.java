package between_extremes.kyu7;

import java.util.Arrays;

public class Kata {
	public static int betweenExtremes(int[] numbers) {
		Arrays.sort(numbers);
		return numbers[numbers.length - 1] - numbers[0];
	}
}
