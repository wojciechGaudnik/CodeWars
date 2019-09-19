package CountPositivesSumNegatives;

import java.util.Arrays;
import java.util.stream.IntStream;
import java.util.stream.Stream;

public class Kata{

	public static void main(String[] args) {
		System.out.println("\033[0;31m" + " test");
		System.out.println(Arrays.toString(countPositivesSumNegatives(new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15})));
		System.out.println(1 + 1 + " test");
		System.out.println(" test" + 1 + 1);
		int[] test = (new int[] {1,1,1,1,1,1,1,2});
		System.out.println((int)IntStream.of(test).average().getAsDouble());

	}



	public static int[] countPositivesSumNegatives(int[] input)	{
		if(input == null || input.length == 0) return new int[]{};
		System.out.println(Arrays.toString(input));
		int count = (int) IntStream.of(input).filter(i -> i > 0).count();
		int sum = IntStream.of(input).filter(i -> i < 0).sum();
		return new int[]{count, sum};
	}
}
