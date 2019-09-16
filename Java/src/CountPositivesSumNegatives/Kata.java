package CountPositivesSumNegatives;

import java.util.Arrays;
import java.util.stream.IntStream;
import java.util.stream.Stream;

public class Kata{

	public static void main(String[] args) {
		System.out.println(Arrays.toString(countPositivesSumNegatives(new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15})));
	}

	public static int[] countPositivesSumNegatives(int[] input)	{
		if(input == null || input.length == 0) return new int[]{};
		System.out.println(Arrays.toString(input));
		int count = (int) IntStream.of(input).filter(i -> i > 0).count();
		int sum = IntStream.of(input).filter(i -> i < 0).sum();
		return new int[]{count, sum};
	}
}
