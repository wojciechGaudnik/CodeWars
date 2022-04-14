package CountPositivesSumNegatives;

import java.util.Arrays;
import java.util.stream.IntStream;

public class Kata {

	public static int[] countPositivesSumNegatives(int[] input) {
		if (input == null || input.length == 0) return new int[]{};
		System.out.println(Arrays.toString(input));
		int count = (int) IntStream.of(input).filter(i -> i > 0).count();
		int sum = IntStream.of(input).filter(i -> i < 0).sum();
		return new int[]{count, sum};
	}
}
