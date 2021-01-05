package smallest_value_of_an_array.kyu7;

import java.util.stream.IntStream;

public class ArraysKata {

	public static int findSmallest( final int[] numbers, final String toReturn ) {
		var smallest = Integer.MAX_VALUE;
		for (int one : numbers) {
			if (smallest > one) {
				smallest = one;
			}
		}
		if (toReturn.equals("value")) {
			return smallest;
		}
		final var smallestFinal =smallest;
		return IntStream.range(0, numbers.length + 1).filter(i -> numbers[i] == smallestFinal).findFirst().getAsInt();
	}
}
